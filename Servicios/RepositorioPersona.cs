using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioPersona
    {
        List<Persona> ObtenerPersonas();
    }
    public class RepositorioPersona: IRepositorioPersona
    {
        public List<Persona> ObtenerPersonas()
        {
            return new List<Persona> {
                new Persona()
                {
                    Nombre = "Martin J. Castro M.",
                    Edad = 48,
                    Descripcion = "Desarrollador Full Stack .NET y JS",
                    TituloDes = "Bienvenido a mi portafolio",
                    PortaDes = "Desarrollo software desde 2000. He tenido la oportunidad de trabajar con distintas empresas en el desarrollo de aplicaciones de C#ASP.NET, SQL SERVER, JS",
                    TituloBackEnd = "Trabajo desde el desarrollo hasta la puesta en producción",
                    TituloFrontEnd = "Desarrollo interfaces ajustadas a la necesidad del negocio y personalizables",
                    HabilidadesBackend = new List<string>()
                                        {
                                            "Web Apis",
                                            "NODE JS",
                                            "Blazor",
                                            "Dapper",
                                            "Queries"
                                         },
                    HabilidadesFrontend = new List<string>()
                                         {
                                            "Hooks",
                                            "JQuery",
                                            "JS",
                                            "AJAX",
                                            "HTML"
                                         }


                }

            };
        }
    }
}
