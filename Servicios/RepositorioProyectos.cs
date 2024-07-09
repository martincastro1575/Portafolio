using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce Realizado en ASP.NET Core",
                    Link = "https://www.amazon.com",
                    ImagenURL = "/img/amazon.png"
                },
                new Proyecto()
                {
                    Titulo = "New York Times",
                    Descripcion = "Página de noticias en NodeJs",
                    Link = "https://www.nytimes.com",
                    ImagenURL = "/img/nyt.png"
                },
                new Proyecto()
                {
                    Titulo = "Reddit",
                    Descripcion = "Red Social para compartir en comunidades",
                    Link = "https://www.reddit.com",
                    ImagenURL = "/img/reddit.png"
                },
                new Proyecto()
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea de videos juegos",
                    Link = "https://www.store.steampowered.com",
                    ImagenURL = "/img/steam.png"
                }
            };
        }
    }
}
