using infoSys.Data;
using infoSys.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace infoSys.Controllers
{
    public class ResumesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ResumesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Resumes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Resume.ToListAsync());
        }



        public async Task<IActionResult> Resume()
        {
            var resume = await _context.Resume
              .FirstOrDefaultAsync(m => m.Default == true);
            if (resume == null)
            {
                return NotFound();
            }
            ViewData["Formations"] = _context.Formation.ToList();
            ViewData["ProfessionalExperience"] = _context.ProfessionalExperience.ToList();
            ViewData["ProjectResume"] = _context.ProjectResume.ToList();
            return View(resume);

        }


        // GET: Resumes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume
                .FirstOrDefaultAsync(m => m.ResumeId == id);
            if (resume == null)
            {
                return NotFound();
            }

            return View(resume);
        }

        // GET: Resumes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Resumes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ResumeId,Name,DOB,Gender,Address,Nationality,Phones,Email,Web,Declaration,Default")] Resume resume, IFormFile Picture)
        {
            if (ModelState.IsValid)
            {

                if (Picture != null)
                {
                    string mimeType = Picture.ContentType;
                    long fileLength = Picture.Length;
                    if (!(mimeType == "" || fileLength == 0))
                    {
                        if (mimeType.Contains("image"))
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await Picture.CopyToAsync(memoryStream);
                                resume.imageContent = memoryStream.ToArray();

                            }
                            resume.imageMimeType = mimeType;
                            resume.imageFileName = Picture.FileName;
                        }
                    }
                }
                resume.Formations = new List<Formation>();
                resume.Experiences = new List<ProfessionalExperience>();
                resume.Projetos = new List<ProjectResume>();
                _context.Add(resume);
                await _context.SaveChangesAsync();

                // return RedirectToAction(nameof(Index));
                //return RedirectToAction("Create", "Formations", new { area = "" });
                return RedirectToAction("Edit", "Resumes", new { id = resume.ResumeId });
            }
            return View(resume);
        }

        // GET: Resumes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume.FindAsync(id);

            if (resume == null)
            {
                return NotFound();
            }

            ViewData["Formations"] = _context.Formation.ToList();
            ViewData["ProfessionalExperience"] = _context.ProfessionalExperience.ToList();
            ViewData["ProjectResume"] = _context.ProjectResume.ToList();


            return View(resume);
        }

        // POST: Resumes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ResumeId,Name,DOB,Gender,Address,Nationality,Phones,Email,Web,Declaration,Default")] Resume resume, IFormFile Picture)
        {
            if (id != resume.ResumeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (Picture != null)
                    {
                        string mimeType = Picture.ContentType;
                        long fileLength = Picture.Length;
                        if (!(mimeType == "" || fileLength == 0))
                        {
                            if (mimeType.Contains("image"))
                            {
                                using (var memoryStream = new MemoryStream())
                                {
                                    await Picture.CopyToAsync(memoryStream);
                                    resume.imageContent = memoryStream.ToArray();

                                }
                                resume.imageMimeType = mimeType;
                                resume.imageFileName = Picture.FileName;
                            }
                        }
                    }


                    _context.Update(resume);
                    //  DefaultModifierAsync(resume);
                    await _context.SaveChangesAsync();

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResumeExists(resume.ResumeId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
                // return RedirectToAction("Create", "ProfessionalExperiences", new { area = "" });
            }
            return View(resume);
        }

        // GET: Resumes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var resume = await _context.Resume
                .FirstOrDefaultAsync(m => m.ResumeId == id);
            if (resume == null)
            {
                return NotFound();
            }

            return View(resume);
        }

        // POST: Resumes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var resume = await _context.Resume.FindAsync(id);
            _context.Resume.Remove(resume);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResumeExists(int id)
        {
            return _context.Resume.Any(e => e.ResumeId == id);
        }

        //public async Task DefaultModifierAsync(Resume resume)
        //{

        //    if (resume.Default == true)
        //    {
        //        foreach (Resume item in _context.Resume)
        //        {
        //            if (item.ResumeId != resume.ResumeId)
        //            {
        //                item.Default = false;
        //              //await _context.SaveChangesAsync();
        //            }
        //        }
        //    }
        //}
    }
}
