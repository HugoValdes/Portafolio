
using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services
{
    public class SendgridMailService : ISendgridMailService
    {
        private readonly IConfiguration configuration;

        public SendgridMailService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task SendEmail(ContactoViewModel contactoViewModel)
        {

            string SendGridAPIKey = this.configuration.GetValue<string>("SENDGRID_API_KEY");
            string SendGridFromEmail = this.configuration.GetValue<string>("SENDGRID_EMAIL_FROM");
            string SendGridFromName = this.configuration.GetValue<string>("SENDGRID_NAME_FROM");

            if (string.IsNullOrEmpty(SendGridAPIKey) || string.IsNullOrEmpty(SendGridFromEmail) || string.IsNullOrEmpty(SendGridFromName))
            {
                return;
            }

            SendGridClient sendGridClient = new SendGridClient(SendGridAPIKey);

            EmailAddress mailAddressFrom, mailAddressTo;

            mailAddressFrom = mailAddressTo = new EmailAddress(SendGridFromEmail, SendGridFromName);

            string mailSubject = $"Tienes un nuevo contacto de {contactoViewModel.Nombre}";

            string mailBodyPlainText = contactoViewModel.Mensaje;

            string mailContentHtml = @$"De: {contactoViewModel.Nombre} Email: {contactoViewModel.Correo} Mensaje: {contactoViewModel.Mensaje}";

            SendGridMessage singleMail = MailHelper.CreateSingleEmail(mailAddressFrom,
                                                                      mailAddressTo,
                                                                      mailSubject,
                                                                      mailBodyPlainText,
                                                                      mailContentHtml);

            Response response = await sendGridClient.SendEmailAsync(singleMail);



        }
    }
}
