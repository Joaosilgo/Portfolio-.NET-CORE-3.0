using Hangfire;
//using WebApplication1.Models;
using infoSys.Areas.Services;
using infoSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace infoSys.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILogger<EmailSender> logger;

        private readonly EmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _emailSender = new EmailSender();


        }

        #region dropbox
        //static async Task Run()
        //{
        //    using (var dbx = new Dropbox.Api.DropboxClient("0qCnoDJAE5AAAAAAAAAAjyY3dBM6nvBUg099m84fT43-KGXFtwr5cIrGLnVivj_7"))
        //    {
        //        var full = await dbx.Users.GetCurrentAccountAsync();
        //        Console.WriteLine("{0} - {1}", full.Name.DisplayName, full.Email);

        //        using (var response = await dbx.Files.DownloadAsync("" + "/" + "CV-Europass-20190326-Gomes-PT.pdf"))
        //        {
        //            //  Console.WriteLine(await response.GetContentAsStringAsync());
        //            using (var fileStream = System.IO.File.Create("Prime_Numbers.pdf"))
        //            {
        //                (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
        //            }
        //        //        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
        //        //    }
        //        }
        //        //using (var response = await client.Files.DownloadAsync("/Homework/math/Prime_Numbers.txt"))
        //        //{
        //        //    using (var fileStream = File.Create("Prime_Numbers.txt"))
        //        //    {
        //        //        (await response.GetContentAsStreamAsync()).CopyTo(fileStream);
        //        //    }

        //        //}
        //    }
        //}
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Contact(Contact contactModel)
        {
            //ViewData["Message"] = "Pode nos contactar através das seguintes formas";
            if (ModelState.IsValid)
            {
                // List<Utilizador> list = new List<Utilizador>();

                if (contactModel.Subject.Equals("Just to Say Hi"))
                {
                    Console.WriteLine("Just Say Hi");

                    //  list = _context.Users.Where(a => a.Cargo.Equals("Administrator")).ToList();
                }
                if (contactModel.Subject.Equals("Business"))
                {
                    // list = _context.Users.Where(a => a.Cargo.Equals("Gestor Adoções")).ToList();
                }
                if (contactModel.Subject.Equals("Other"))
                {
                    // list = _context.Users.Where(a => a.Cargo.Equals("Gestor Animais")).ToList();
                }
                //foreach (Utilizador item in list)
                //{
                try
                {

                    await _emailSender.SendEmailAsync(contactModel.Email, contactModel.Subject, contactModel.Message);

                    BackgroundJob.Enqueue(() => _emailSender.SendReplyAsync(contactModel.Email, "JoaoGomes-Notifications", "Obrigado Por Nos ter contactado "));
                    //  await _emailSender.SendEmailAsync(contactModel.Email, contactModel.Subject, contactModel.Message);
                    /////////////////

                    //var apiKey = "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";
                    //var client = new SendGridClient(apiKey);
                    //var msg = new SendGridMessage()
                    //{
                    //    From = new EmailAddress("noreply@joaogomes.com", "JoaoGomes-Notification"),
                    //    Subject = contactModel.Subject,
                    //    //  PlainTextContent = "Hello, Email!",
                    //    HtmlContent = contactModel.Message
                    //};
                    //msg.AddTo(new EmailAddress(contactModel.Email, "João Gomes"));
                    //var response = await client.SendEmailAsync(msg);


                    /////////////////
                    //var apiKey = "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";
                    //var client = new SendGridClient(apiKey);
                    //var msg = new SendGridMessage()
                    //{
                    //   From = new EmailAddress(contactModel.Email, "JoãoGomesWeb-Notificação"),
                    //    Subject = contactModel.Subject,
                    //    HtmlContent = contactModel.Message
                    //};
                    //msg.AddTo(new EmailAddress("joaosilgo96@gmail.com", "João Gomes"));
                    //var response = await client.SendEmailAsync(msg);
                    ViewBag.Message = "Obrigado por nos Contactar ";


                }

                catch (Exception ex)
                {
                    ModelState.Clear();
                    ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
                }
            }

            return View();

        }



        public IActionResult OnlineStats()
        {
            return View();
        }














        public async Task<IActionResult> Download()
        {
            //if (filename == null)
            //    return Content("filename not present");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           "wwwroot", "JoãoGomes.pdf");

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }




    }
}
