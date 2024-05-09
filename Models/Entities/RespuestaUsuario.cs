namespace apiCuestionario.Models.Entities
{
    public class RespuestaUsuario
    {
        public int IdRespuestaUsuario { get; set; }
        public int IdCuestionario { get; set; }
        public int IdPersona { get; set; }
        public int IdPregunta { get; set; }
        public int IdRespuesta {  get; set; }
        public DateTime Fecha { get; set; }

    }
}
