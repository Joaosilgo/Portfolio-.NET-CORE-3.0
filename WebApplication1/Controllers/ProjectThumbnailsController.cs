using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class ProjectThumbnailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectThumbnailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectThumbnails
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectThumbnails.ToListAsync());
        }

        // GET: ProjectThumbnails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectThumbnails = await _context.ProjectThumbnails
                .FirstOrDefaultAsync(m => m.ProjectThumbnailId == id);
            if (projectThumbnails == null)
            {
                return NotFound();
            }

            return View(projectThumbnails);
        }

        // GET: ProjectThumbnails/Create
        public IActionResult Create()
        {
            // ViewData["ProjectId"] = new SelectList(_context.Set<Project>(), "Id", "Id");
            //  ViewData["Project"] = _context.Project.ToList();
            ViewData["Project"] = new SelectList(_context.Project, "Id", "Id");
            return View();
            //  return View();
        }

        // POST: ProjectThumbnails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectThumbnailId,Name,Description,ProjectId")] ProjectThumbnails projectThumbnails, IFormFile thumbnail, int projectId)
        {
            if (ModelState.IsValid)
            {


                //var project = await _context.Project
                //    .FindAsync(projectId);
                // var project = await _context.Project
                //.FirstOrDefaultAsync(m => m.Id == projectId);


                //if (project == null)
                //{
                //    return NotFound();
                //}
                //projectThumbnails.Id = projectId;


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
                                projectThumbnails.imageContent = memoryStream.ToArray();

                            }
                            projectThumbnails.imageMimeType = mimeType;
                            projectThumbnails.imageFileName = thumbnail.FileName;
                        }
                    }
                }

                // projectThumbnails.Project = new List<ProjectResume>();
                _context.Add(projectThumbnails);
                //projectThumbnails.Id = project.Id;
                await _context.SaveChangesAsync();
                //  return RedirectToAction(nameof(Index));
                return RedirectToAction("Edit", "Projects", new { id = projectThumbnails.ProjectId });
            }
            // ViewData["ProjectId"] = new SelectList(_context.Set<Project>(), "Id", "Id");
            ViewData["Project"] = new SelectList(_context.Project, "Id", "Id");
            return View(projectThumbnails);
        }

        // GET: ProjectThumbnails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectThumbnails = await _context.ProjectThumbnails.FindAsync(id);
            if (projectThumbnails == null)
            {
                return NotFound();
            }
            return View(projectThumbnails);
        }

        // POST: ProjectThumbnails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectThumbnailId,Name,Description,ProjectId")] ProjectThumbnails projectThumbnails)
        {
            if (id != projectThumbnails.ProjectThumbnailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectThumbnails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectThumbnailsExists(projectThumbnails.ProjectThumbnailId))
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
            return View(projectThumbnails);
        }

        // GET: ProjectThumbnails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectThumbnails = await _context.ProjectThumbnails
                .FirstOrDefaultAsync(m => m.ProjectThumbnailId == id);
            if (projectThumbnails == null)
            {
                return NotFound();
            }

            return View(projectThumbnails);
        }

        // POST: ProjectThumbnails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectThumbnails = await _context.ProjectThumbnails.FindAsync(id);
            _context.ProjectThumbnails.Remove(projectThumbnails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectThumbnailsExists(int id)
        {
            return _context.ProjectThumbnails.Any(e => e.ProjectThumbnailId == id);
        }
    }
}
