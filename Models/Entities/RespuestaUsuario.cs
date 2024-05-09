namespace apiCuestionario.Models.Entities
{
    public class RespuestaUsuario
    {
        public int IdRespuestaUsuario { get; set; }
        public int IdCuestionario { get; set; }
        public int IdUsuario { get; set; }
        public int IdPregunta { get; set; }
        public int IdRespuesta {  get; set; }
        public DateTime fecha { get; set; }

    }
}
