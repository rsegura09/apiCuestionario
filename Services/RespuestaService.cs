using apiCuestionario.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace apiCuestionario.Services
{
    public interface IRespuestaService
    {
        IEnumerable<Respuesta> ListarRespuestas();
        Task GuardarRespuesta(Respuesta respuesta);
        Respuesta BuscarRespuesta(int id);

    }
    public class RespuestaService: IRespuestaService
    {
        CuestionarioContext _db;
        IPreguntaService _preguntaService;

        public RespuestaService(CuestionarioContext db, IPreguntaService _preguntaService)
        {
            _db = db;
            this._preguntaService = _preguntaService;
        }

        public IEnumerable<Respuesta> ListarRespuestas()
        {
            return _db.Respuestas;
        }

        public async Task GuardarRespuesta(Respuesta respuesta)
        {
            var pregunta = _preguntaService.BuscarPregunta(respuesta.IdPregunta);
            if (pregunta != null)
            {
                _db.Respuestas.Add(respuesta);
                await _db.SaveChangesAsync();
            }
            else
            {

            }
        }

        public Respuesta BuscarRespuesta(int id)
        {
            var respuesta = _db.Respuestas.Find(id);
            return respuesta;
        }
    }
}
