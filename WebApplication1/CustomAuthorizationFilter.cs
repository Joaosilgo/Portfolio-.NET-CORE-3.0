using Hangfire.Dashboard;
//using Microsoft.Extensions.DependencyInjection;

namespace infoSys
{
    //public class HangfireAuthorizationFilter : IDashboardAuthorizationFilter
    //{
    //    private string policyName;

    //    public HangfireAuthorizationFilter(string policyName)
    //    {
    //        this.policyName = policyName;
    //    }

    //    public bool Authorize([NotNull] DashboardContext context)
    //    {
    //        var httpContext = context.GetHttpContext();
    //        var authService = httpContext.RequestServices.GetRequiredService<IAuthorizationService>();
    //        //return authService.AuthorizeAsync(httpContext.User, this.policyName).ConfigureAwait(false).GetAwaiter().GetResult();
    //        return httpContext.User.Identity.IsAuthenticated;
    //    }
    //}
    //  public class CustomAuthorizeFilter : IDashboardAuthorizationFilter
    //{
    //    public bool Authorize([NotNull] DashboardContext context)
    //    {
    //        var httpcontext = context.GetHttpContext();
    //        return httpcontext.User.Identity.IsAuthenticated;
    //    }
    //}

    public class CustomAuthorizationFilter : IDashboardAuthorizationFilter
    {

        public bool Authorize(DashboardContext context)
        {
            var httpcontext = context.GetHttpContext();
            if (httpcontext.User.Identity.IsAuthenticated/*.IsInRole("Admin")*/)
            {
                return true;
            }
            var httpContext = context.GetHttpContext();
            httpContext.Response.Redirect("/Identity/Account/Login");
            // httpContext.Response.Redirect("/hangfire");
            return true; //always return true

        }
    }





}

