using apiCuestionario.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;



namespace apiCuestionario.Services
{
    public interface IPreguntaService
    {
        IEnumerable<Pregunta> ListarPreguntas();
        Task GuardarPregunta(Pregunta pregunta);
        Pregunta BuscarPregunta(int id);

        void EliminarPregunta(Pregunta pregunta);
    }

    public class PreguntaService: IPreguntaService
    {
        CuestionarioContext _db;
        ICuestionarioService _cuestionarioService;

        public PreguntaService(CuestionarioContext db, ICuestionarioService cuestionarioService)
        {
            this._db = db;
            _cuestionarioService = cuestionarioService;
        }

        public IEnumerable<Pregunta> ListarPreguntas()
        {
            return _db.Preguntas;
        }

        public Pregunta BuscarPregunta(int id)
        {
            var pregunta = _db.Preguntas.Find(id);
            return pregunta;
        }

        public async Task GuardarPregunta(Pregunta pregunta)
        {
            var cuestionario = _cuestionarioService.ConsultarUnCuestionario(pregunta.IdCuestionario);
            if (cuestionario != null)
            {
                _db.Preguntas.Add(pregunta);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new InvalidOperationException("No se encontró el cuestionario correspondiente para guardar la pregunta.");
            }
        }

        public void EliminarPregunta(Pregunta pregunta)
        {
            _db.Preguntas.Remove(pregunta);
            _db.SaveChanges();
        }

    }
}
