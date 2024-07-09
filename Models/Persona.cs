namespace Portafolio.Models
{
    public class Persona
    {
        public string? Nombre { get; set; }

        public string? Descripcion { get; set; }
        public string? TituloDes { get; set; }
        public string? PortaDes { get; set; }
        public string? TituloBackEnd { get; set; }
        public string? TituloFrontEnd { get; set; }
        
        public List<string>? HabilidadesBackend { get; set; }
        public List<string>? HabilidadesFrontend { get; set; }

        public int Edad { get; set; }
        

}
}
