namespace apiCuestionario.Models.Entities
{
    public class Respuesta
    {
        public int IdRespuesta { get; set; }
        public int IdPregunta { get; set; }
        public string? RespuestaCampo { get; set; }
    }
}
