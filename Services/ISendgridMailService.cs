using Portafolio.Models;

namespace Portafolio.Services
{
    /// <summary>
    /// Interface Sendgrid Service
    /// </summary>
    public interface ISendgridMailService
    {
        Task SendEmail(ContactoViewModel contactoViewModel);
    }
}
