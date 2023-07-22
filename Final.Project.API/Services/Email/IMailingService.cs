namespace Final.Project.API;
public interface IMailingService
{
    Task SendEmailAsync(string mailTo, string subject, string body);
}
