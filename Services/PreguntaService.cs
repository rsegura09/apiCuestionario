using apiCuestionario.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace apiCuestionario.Services
{
    public interface IPreguntaService
    {
        IEnumerable<Pregunta> ListarPreguntas();
    }

    public class PreguntaService: IPreguntaService
    {
        CuestionarioContext db;

        public PreguntaService(CuestionarioContext db)
        {
            this.db = db;
        }

        public IEnumerable<Pregunta> ListarPreguntas()
        {
            return db.Preguntas;
        }
    }
}
