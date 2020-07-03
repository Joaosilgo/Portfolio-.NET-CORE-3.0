using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class FormationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Formations
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Formation.Include(f => f.Resume);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Formations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formation
                .Include(f => f.Resume)
                .FirstOrDefaultAsync(m => m.FormationId == id);
            if (formation == null)
            {
                return NotFound();
            }

            return View(formation);
        }

        // GET: Formations/Create
        public IActionResult Create()
        {
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId");
            return View();
        }

        // POST: Formations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormationId,DateBegin,DateEnd,FormationDesig,FormationOrganization,FormationSkills,ResumeId")] Formation formation)
        {
            if (ModelState.IsValid)
            {
                //
                //var result= _context.Resume.LastOrDefaultAsync(x=> x.ResumeId);
                // var result = (from latest in _context.Resume select latest).Last();
                //var result = _context.Resume.FromSqlRaw("SCOPE_IDENTITY()").ToList().FirstOrDefault();
                var result = _context.Resume.First<Resume>();
                formation.ResumeId = result.ResumeId;
                //

                _context.Add(formation);
                formation.Resume.Formations.Add(formation);
                await _context.SaveChangesAsync();
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Edit", "Resumes", new { id = formation.ResumeId });
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", formation.ResumeId);
            return View(formation);
        }

        // GET: Formations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formation.FindAsync(id);
            if (formation == null)
            {
                return NotFound();
            }

            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", formation.ResumeId);
            return View(formation);
        }

        // POST: Formations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormationId,DateBegin,DateEnd,FormationDesig,FormationOrganization,FormationSkills,ResumeId")] Formation formation)
        {
            if (id != formation.FormationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormationExists(formation.FormationId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Edit", "Resumes", new { id = formation.ResumeId });
                //  return RedirectToAction(nameof(Index));
            }
            ViewData["ResumeId"] = new SelectList(_context.Set<Resume>(), "ResumeId", "ResumeId", formation.ResumeId);
            return View(formation);
        }

        // GET: Formations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formation = await _context.Formation
                .Include(f => f.Resume)
                .FirstOrDefaultAsync(m => m.FormationId == id);
            if (formation == null)
            {
                return NotFound();
            }

            return View(formation);
        }

        // POST: Formations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formation = await _context.Formation.FindAsync(id);
            _context.Formation.Remove(formation);
            await _context.SaveChangesAsync();
            return RedirectToAction("Edit", "Resumes", new { id = formation.ResumeId });
            //  return RedirectToAction(nameof(Index));
        }

        private bool FormationExists(int id)
        {
            return _context.Formation.Any(e => e.FormationId == id);
        }
    }
}
