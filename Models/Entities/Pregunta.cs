namespace apiCuestionario.Models.Entities
{
    public class Pregunta
    {
        public int IdPregunta { get; set; }
        public int IdCuestionario { get; set; }
        public string PreguntaCampo { get; set; }
        public string TipoDePregunta { get; set; }
        public string TipoDeRespuesta {  get; set; }
        public DateTime FechaDeEjecucion {  get; set; }

    }
}
