using Hangfire;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace infoSys.Areas.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> _logger;
        public EmailSender( /*ILogger<EmailSender> logger*/)
        {

            //  _logger = logger;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("noreply@joaogomes.com", "JoaoGomes-Notification"),

                // "noreply@joaogomes.com"
                Subject = subject,
                //  PlainTextContent = "Hello, Email!",
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress("joaosilgo96@gmail.com", "João Gomes"));
            var response = await client.SendEmailAsync(msg);
            // response.sta
            BackgroundJob.Enqueue(() => Console.WriteLine(response.ToString()));
        }





        public async Task SendReplyAsync(string email, string subject, string message)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("noreply@joaogomes.com", "JoaoGomes-Notification"),


                // "noreply@joaogomes.com"
                Subject = subject,
                //  PlainTextContent = "Hello, Email!",
                HtmlContent = message

            };
            msg.AddTo(new EmailAddress(email, "email"));

            var response = await client.SendEmailAsync(msg);
            // response.sta
            BackgroundJob.Enqueue(() => Console.WriteLine(response.ToString()));
        }




    }
}
