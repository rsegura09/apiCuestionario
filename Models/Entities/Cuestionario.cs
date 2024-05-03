namespace apiCuestionario.Models.Entities
{
    public class Cuestionario
    {
        public int IdCuestionario { get; set; }
        public int IdUser { get; set; }
        public string? Titulo {  get; set; }
        public string? Descripcion {  get; set; }
        public DateTime FechaDeCreacion { get; set; }
        public DateTime FechaDeEjecucion { get; set; }
    }
}
