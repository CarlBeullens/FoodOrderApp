using FoodOrderApp.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace FoodOrderApp.Services.EmailService;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;
    
    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    public async Task<bool> SendEmailAsync(ContactForm form)
    {
        var success = false;
        var mailSettings = _configuration.GetSection("MailSettings");
        
        using var email = new MimeMessage();
        email.From.Add(new MailboxAddress(form.Name, form.Email));
        email.To.Add(MailboxAddress.Parse(
            mailSettings["Mail"] ?? throw new InvalidOperationException("Recipient email not configured")));
        email.Subject = $"Contact Form: {form.Name}";
        email.Body = new BodyBuilder { HtmlBody = 
            $"From: {form.Name}<br>Email: {form.Email}<br>Message: {form.Message}" 
        }.ToMessageBody();

        try 
        {
            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(
                mailSettings["Host"],
                int.Parse(mailSettings["Port"] ?? throw new InvalidOperationException("SMTP port not configured")),
                SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(mailSettings["Mail"], mailSettings["Password"]);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

            success = true;
        }
        catch (Exception ex)
        {
            throw new ApplicationException("Failed to send email", ex);
        }

        return success;
    }
}