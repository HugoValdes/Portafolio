using Portafolio.Models;

namespace Portafolio.Services
{
 
    /// <summary>
    /// Interface Repository Proyecto Model
    /// </summary>
    public interface IProyectoRepository
    {
        List<Proyecto> GetProyectos();
    }
}
