using FoodOrderApp.Models;

namespace FoodOrderApp.Services.EmailService;

public interface IEmailService
{
    Task<bool> SendEmailAsync(ContactForm form);
}