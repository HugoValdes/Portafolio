using Portafolio.Models;

namespace Portafolio.Services
{
    public class ProyectoRepository : IProyectoRepository
    {
        public List<Proyecto> GetProyectos()
        {

            return new List<Proyecto> {
                new Proyecto()
                {
                    Titulo = "Formulario de votaciones",
                    Descripcion = "Formulario de votaciones con PHP",
                    URL = "https://github.com/HugoValdes/sistema-votacion-desis",
                    ImagenURL = "https://i0.wp.com/metalkit.cl/wp-content/uploads/2024/01/placeholder-285-1.png?ssl=1"
                },
                new Proyecto()
                {
                    Titulo = "Formulario de votaciones",
                    Descripcion = "Formulario de votaciones con PHP",
                    URL = "https://github.com/HugoValdes/sistema-votacion-desis",
                    ImagenURL = "https://i0.wp.com/metalkit.cl/wp-content/uploads/2024/01/placeholder-285-1.png?ssl=1"
                },
                new Proyecto()
                {
                    Titulo = "Formulario de votaciones",
                    Descripcion = "Formulario de votaciones con PHP",
                    URL = "https://github.com/HugoValdes/sistema-votacion-desis",
                    ImagenURL = "https://i0.wp.com/metalkit.cl/wp-content/uploads/2024/01/placeholder-285-1.png?ssl=1"
                },
                new Proyecto()
                {
                    Titulo = "Formulario de votaciones",
                    Descripcion = "Formulario de votaciones con PHP",
                    URL = "https://github.com/HugoValdes/sistema-votacion-desis",
                    ImagenURL = "https://i0.wp.com/metalkit.cl/wp-content/uploads/2024/01/placeholder-285-1.png?ssl=1"
                }
            };

        }

    }

}
