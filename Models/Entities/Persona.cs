namespace apiCuestionario.Models.Entities
{
    public class Persona
    {
        public int IdPersona { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contrasenna {get; set;}
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaDeRegistro {  get; set; }
        public string? Rol {  get; set; }
    }
}
