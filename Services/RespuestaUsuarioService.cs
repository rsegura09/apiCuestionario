using apiCuestionario.Models.Entities;

namespace apiCuestionario.Services
{
    public interface IRespuestaUsuarioService
    {
        IEnumerable<RespuestaUsuario> ListarRespuestaUsuario();
        Task GuardarRespuestaUsuario(RespuestaUsuario respuestaUsuario);
        RespuestaUsuario BuscarRespuestaUsuario(int id);
        void EliminarRespuestaUsuario(RespuestaUsuario respuestaUsuario);

    }

    public class RespuestaUsuarioService : IRespuestaUsuarioService
    {
        CuestionarioContext _db;

        public RespuestaUsuarioService(CuestionarioContext db)
        {
            _db = db;
        }

        public IEnumerable<RespuestaUsuario> ListarRespuestaUsuario()
        {
            return _db.RespuestaUsuario;
        }

        public async Task GuardarRespuestaUsuario(RespuestaUsuario respuestaUsuario)
        {
            _db.RespuestaUsuario.Add(respuestaUsuario);
            await _db.SaveChangesAsync();
        }

        public RespuestaUsuario BuscarRespuestaUsuario(int id)
        {
            var respuesta = _db.RespuestaUsuario.Find(id);
            return respuesta;
        }

        public void EliminarRespuestaUsuario(RespuestaUsuario respuestaUsuario)
        {
            _db.RespuestaUsuario.Remove(respuestaUsuario);
            _db.SaveChanges();
        }
    }
}
