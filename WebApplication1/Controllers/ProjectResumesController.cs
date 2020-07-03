using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class ProjectResumesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectResumesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProjectResumes
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProjectResume.Include(p => p.Resume);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProjectResumes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectResume = await _context.ProjectResume
                .Include(p => p.Resume)
                .FirstOrDefaultAsync(m => m.ProjectResumeId == id);
            if (projectResume == null)
            {
                return NotFound();
            }

            return View(projectResume);
        }

        // GET: ProjectResumes/Create
        public IActionResult Create()
        {
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId");
            return View();
        }

        // POST: ProjectResumes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProjectResumeId,description,ResumeId")] ProjectResume projectResume)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Resume.First<Resume>();
                projectResume.ResumeId = result.ResumeId;

                _context.Add(projectResume);
                await _context.SaveChangesAsync();
                //  return RedirectToAction(nameof(Index));
                return RedirectToAction("Edit", "Resumes", new { id = projectResume.ResumeId });
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", projectResume.ResumeId);
            return View(projectResume);
        }

        // GET: ProjectResumes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectResume = await _context.ProjectResume.FindAsync(id);
            if (projectResume == null)
            {
                return NotFound();
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", projectResume.ResumeId);
            return View(projectResume);
        }

        // POST: ProjectResumes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProjectResumeId,description,ResumeId")] ProjectResume projectResume)
        {
            if (id != projectResume.ProjectResumeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectResume);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectResumeExists(projectResume.ProjectResumeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Edit", "Resumes", new { id = projectResume.ResumeId });
                //  return RedirectToAction(nameof(Index));
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", projectResume.ResumeId);
            return View(projectResume);
        }

        // GET: ProjectResumes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectResume = await _context.ProjectResume
                .Include(p => p.Resume)
                .FirstOrDefaultAsync(m => m.ProjectResumeId == id);
            if (projectResume == null)
            {
                return NotFound();
            }

            return View(projectResume);
        }

        // POST: ProjectResumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projectResume = await _context.ProjectResume.FindAsync(id);
            _context.ProjectResume.Remove(projectResume);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Resumes", new { id = projectResume.ResumeId });
            //  return RedirectToAction(nameof(Index));
        }

        private bool ProjectResumeExists(int id)
        {
            return _context.ProjectResume.Any(e => e.ProjectResumeId == id);
        }
    }
}
