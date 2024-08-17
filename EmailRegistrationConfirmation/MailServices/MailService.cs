using EmailRegister.Models;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;

namespace EmailRegister.MailServices
{
    public class MailService : IMailService
    {
        private readonly SmtpSettings _smtpSettings;

        public MailService(IOptions<SmtpSettings> smtpSettings)
        {
            _smtpSettings = smtpSettings.Value;
        }

        public async Task SendMailAsync(string mail, string subject, string message)
        {
            try
            {
                var newEmail = new MimeMessage();
                newEmail.From.Add(MailboxAddress.Parse("ADD-YOUR-EMAIL"));
                newEmail.To.Add(MailboxAddress.Parse(mail));
                newEmail.Subject = subject;

                var builder = new BodyBuilder();
                builder.HtmlBody = message;
                newEmail.Body = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync(_smtpSettings.Server, _smtpSettings.Port, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_smtpSettings.SenderName, _smtpSettings.Password);
                    await client.SendAsync(newEmail);
                    await client.DisconnectAsync(true);
                }
            }
            catch(Exception ex) 
            {
                throw new InvalidOperationException($"Eposta gönderilirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
