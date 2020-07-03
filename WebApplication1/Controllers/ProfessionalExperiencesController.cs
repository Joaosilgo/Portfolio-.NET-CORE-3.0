using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class ProfessionalExperiencesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProfessionalExperiencesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ProfessionalExperiences
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ProfessionalExperience.Include(p => p.Resume);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ProfessionalExperiences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperience
                .Include(p => p.Resume)
                .FirstOrDefaultAsync(m => m.ProfessionalExperienceId == id);
            if (professionalExperience == null)
            {
                return NotFound();
            }

            return View(professionalExperience);
        }

        // GET: ProfessionalExperiences/Create
        public IActionResult Create()
        {
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId");
            return View();
        }

        // POST: ProfessionalExperiences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProfessionalExperienceId,DateBegin,DateEnd,Role,Employer,Activities_Responsibilities,ResumeId")] ProfessionalExperience professionalExperience)
        {
            if (ModelState.IsValid)
            {
                var result = _context.Resume.First<Resume>();
                professionalExperience.ResumeId = result.ResumeId;

                _context.Add(professionalExperience);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Edit", "Resumes", new { id = professionalExperience.ResumeId });
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", professionalExperience.ResumeId);
            return View(professionalExperience);

        }

        // GET: ProfessionalExperiences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperience.FindAsync(id);
            if (professionalExperience == null)
            {
                return NotFound();
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", professionalExperience.ResumeId);
            return View(professionalExperience);
        }

        // POST: ProfessionalExperiences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProfessionalExperienceId,DateBegin,DateEnd,Role,Employer,Activities_Responsibilities,ResumeId")] ProfessionalExperience professionalExperience)
        {
            if (id != professionalExperience.ProfessionalExperienceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(professionalExperience);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProfessionalExperienceExists(professionalExperience.ProfessionalExperienceId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Edit", "Resumes", new { id = professionalExperience.ResumeId });
                // return RedirectToAction(nameof(Index));
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", professionalExperience.ResumeId);
            return View(professionalExperience);
        }

        // GET: ProfessionalExperiences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professionalExperience = await _context.ProfessionalExperience
                .Include(p => p.Resume)
                .FirstOrDefaultAsync(m => m.ProfessionalExperienceId == id);
            if (professionalExperience == null)
            {
                return NotFound();
            }

            return View(professionalExperience);
        }

        // POST: ProfessionalExperiences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var professionalExperience = await _context.ProfessionalExperience.FindAsync(id);
            _context.ProfessionalExperience.Remove(professionalExperience);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Resumes", new { id = professionalExperience.ResumeId });
            //return RedirectToAction(nameof(Index));
        }

        private bool ProfessionalExperienceExists(int id)
        {
            return _context.ProfessionalExperience.Any(e => e.ProfessionalExperienceId == id);
        }
    }
}
