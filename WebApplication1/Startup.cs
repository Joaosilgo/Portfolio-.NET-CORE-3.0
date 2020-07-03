using Hangfire;
using Hangfire.SqlServer;
using infoSys.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace infoSys
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>

                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection"))
                // .EnableSensitiveDataLogging(false)


                );
            // services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //.AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.User.AllowedUserNameCharacters = @"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 -._@+ ";
                options.SignIn.RequireConfirmedEmail = true;




            })

          .AddDefaultUI()
          .AddDefaultTokenProviders()
          .AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddHangfire(configuration => configuration
       .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
       .UseSimpleAssemblyNameTypeSerializer()
       .UseRecommendedSerializerSettings()

       .UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
       {
           CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
           SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
           QueuePollInterval = TimeSpan.Zero,
           UseRecommendedIsolationLevel = true,
           UsePageLocksOnDequeue = true,
           DisableGlobalLocks = true
       }));


            // Add the processing server as IHostedService
            services.AddHangfireServer();
            services.AddControllersWithViews()
            //services.AddServerSideBlazor();
            // services.AddRazorPages()
                 .AddRazorPagesOptions(options =>
                 {
                     options.Conventions.AuthorizePage("/Home/Contact");
                     options.Conventions.AuthorizePage("/Projects/Edit/...");
                     // options.Conventions
                     //options.Conventions.AuthorizeFolder("/Private");
                     //options.Conventions.AllowAnonymousToPage("/Private/PublicPage");
                     //options.Conventions.AllowAnonymousToFolder("/Private/PublicPages");
                 });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";

            });
            services.AddHttpClient();












        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IBackgroundJobClient backgroundJobs, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();






            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            var options = new DashboardOptions
            {
                Authorization = new[] { new CustomAuthorizationFilter() }


            };


            app.UseHangfireDashboard("/hangfire", options);

            // backgroundJobs.Enqueue(() => Console.WriteLine("Hello world from Hangfire!"));








            app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapRazorPages();

        });

            CreateRolesAndAdminUser(serviceProvider);
        }





        private static void CreateRolesAndAdminUser(IServiceProvider serviceProvider)
        {
            const string adminRoleName = "Administrador";
            string[] roleNames = { adminRoleName, "Utilizador" };

            foreach (string roleName in roleNames)
            {
                CreateRole(serviceProvider, roleName);
            }

            // Get these value from "appsettings.json" file.
            string adminUserEmail = "joaosilgo96@gmail.com";
            string adminPwd = "Jo@og0mes";



            //  string adminUserEmail = "joaosilgo96@gmail.com";
            //  string adminPwd = "Jo@og0mes";
            AddUserToRole(serviceProvider, adminUserEmail, adminPwd, adminRoleName);

            //  Utilizador user = await UserManager.FindByEmailAsync("joaosilgo96@gmail.com");
        }

        /// <summary>
        /// Criar um role se não existir.
        /// </summary>
        /// <param name="serviceProvider">Service Provider</param>
        /// <param name="roleName">Role Name</param>
        private static void CreateRole(IServiceProvider serviceProvider, string roleName)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            Task<bool> roleExists = roleManager.RoleExistsAsync(roleName);
            roleExists.Wait();

            if (!roleExists.Result)
            {
                Task<IdentityResult> roleResult = roleManager.CreateAsync(new IdentityRole(roleName));
                roleResult.Wait();
            }
        }

        /// <summary>
        /// Adiciona uma utilizador a um role se este existir, caso contrario, cria um utilizador e adiciona-o ao role.
        /// </summary>
        /// <param name="serviceProvider">Service Provider</param>
        /// <param name="userEmail">User Email</param>
        /// <param name="userPwd">User Password. Used to create the user if not exists.</param>
        /// <param name="roleName">Role Name</param>
        private static void AddUserToRole(IServiceProvider serviceProvider, string userEmail,
            string userPwd, string roleName)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            Task<IdentityUser> checkAppUser = userManager.FindByEmailAsync(userEmail);
            checkAppUser.Wait();


            IdentityUser appUser = checkAppUser.Result;

            if (checkAppUser.Result == null)
            {
                IdentityUser newAppUser = new IdentityUser
                {

                    //DBO = DateTime.Now,
                    //Morada = "ADMIN",
                    //Genero = "ADMIN",
                    //Nome = "AMIN",

                    Email = userEmail,
                    UserName = userEmail,
                    NormalizedEmail = userEmail
                    // Cargo = "Administrator"

                };
                newAppUser.EmailConfirmed = true;
                Task<IdentityResult> taskCreateAppUser = userManager.CreateAsync(newAppUser, userPwd);
                taskCreateAppUser.Wait();

                if (taskCreateAppUser.Result.Succeeded)
                {
                    appUser = newAppUser;
                }
            }

            Task<IdentityResult> newUserRole = userManager.AddToRoleAsync(appUser, roleName);
            newUserRole.Wait();
        }














    }




}



