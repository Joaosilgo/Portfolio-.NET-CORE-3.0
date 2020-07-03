using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpClientFactory _clientFactory;
        public IEnumerable<Project> Repos { get; private set; }

        public ProjectsController(IHttpClientFactory clientFactory, ApplicationDbContext context)
        {
            _clientFactory = clientFactory;
            _context = context;

        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {

            //var request = new HttpRequestMessage(HttpMethod.Get,
            //  //"https://api.github.com/repos/aspnet/AspNetCore.Docs/branches");
            //  "https://api.github.com/users/Joaosilgo/repos");
            //request.Headers.Add("Accept", "application/vnd.github.v3+json");
            //request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            //var client = _clientFactory.CreateClient();

            //var response = await client.SendAsync(request);

            //if (response.IsSuccessStatusCode)
            //{
            //    Repos = await response.Content
            //        .ReadAsAsync<IEnumerable<Project>>();
            //    foreach (Project element in Repos)
            //    {
            //        Console.WriteLine(element.Name.ToString());


            //        // Console.WriteLine(element.SmallDescription.ToString());
            //        // _context.Project.Add(new Project {Name=element.Name,  });
            //        using (var transaction = _context.Database.BeginTransaction())
            //        {



            //            _context.Project.Add(element);
            //            // _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Project ON;");
            //            _context.SaveChanges();
            //            // _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Project OFF");
            //            transaction.Commit();


            //        }

            //        // _context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT aspnet-infoSys-905049F1-0BD4-465D-9760-1E0D168B344F.Projects ON;");
            //        await _context.SaveChangesAsync();

            //    }
            //}
            //else
            //{
            //    //GetBranchesError = true;
            //    Repos = Array.Empty<Project>();
            //}
            await DoStuffAsync();
            return View(await _context.Project.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                 .Include(p => p.ProjectThumbnails)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            ViewData["ProjectThumbnails"] = _context.ProjectThumbnails.ToList();

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,SmallDescription,Description,created_at,updated_at,pushed_at,size_kb,Language,Languages,Link,Features,Intent,Difficulties,Solution")] Project project, IFormFile thumbnail)
        {
            if (ModelState.IsValid)
            {
                if (thumbnail != null)
                {
                    string mimeType = thumbnail.ContentType;
                    long fileLength = thumbnail.Length;
                    if (!(mimeType == "" || fileLength == 0))
                    {
                        if (mimeType.Contains("image"))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await thumbnail.CopyToAsync(memoryStream);
                                project.imageContent = memoryStream.ToArray();

                            }
                            project.imageMimeType = mimeType;
                            project.imageFileName = thumbnail.FileName;
                        }
                    }
                }
                project.ProjectThumbnails = new List<ProjectThumbnails>();
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FindAsync(id);
            if (project == null)
            {
                return NotFound();
            }
            ViewData["ProjectThumbnails"] = _context.ProjectThumbnails.ToList();
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,SmallDescription,Description,created_at,updated_at,pushed_at,size_kb,Language,Languages,Link,Features,Intent,Difficulties,Solution")] Project project, IFormFile thumbnail)
        {
            if (id != project.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    //começa aqui
                    if (thumbnail == null)
                    {
                        project.imageContent = project.imageContent;
                        project.imageFileName = project.imageFileName;

                        project.imageMimeType = project.imageMimeType;
                    }
                    else
                    {
                        if (thumbnail != null)
                        {
                            string mimeType = thumbnail.ContentType;
                            long fileLength = thumbnail.Length;
                            if (!(mimeType == "" || fileLength == 0))
                            {
                                if (mimeType.Contains("image"))
                                {
                                    using (var memoryStream = new MemoryStream())
                                    {
                                        await thumbnail.CopyToAsync(memoryStream);
                                        project.imageContent = memoryStream.ToArray();

                                    }
                                    project.imageMimeType = mimeType;
                                    project.imageFileName = thumbnail.FileName;
                                }

                            }
                        }
                    }
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProjectThumbnails"] = _context.ProjectThumbnails.ToList();
            return View(project);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project
                .FirstOrDefaultAsync(m => m.Id == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Project.FindAsync(id);
            _context.Project.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectExists(int id)
        {
            return _context.Project.Any(e => e.Id == id);
        }











        public async Task DoStuffAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com/users/Joaosilgo/repos");
            request.Headers.Add("Accept", "application/vnd.github.v3+json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            var client = _clientFactory.CreateClient();

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(await response.Content.ReadAsStringAsync());
                Repos = await response.Content
                    .ReadAsAsync<IEnumerable<Project>>();

                foreach (var item in Repos)
                {
                    //  _context.Entry(item).State = !_context.Project.Any(f => f.Id == item.Id) ? EntityState.Added : EntityState.Modified;/*: EntityState.Modified;*/
                    //  _context.Project.Add(item).;
                    if (!_context.Project.Any(f => f.Id == item.Id))
                    {
                        _context.Project.Add(item);
                    }
                    _context.SaveChanges();
                }


            }





        }
    }
}

