using apiCuestionario.Models.Entities;

namespace apiCuestionario.Services
{
    public interface ICuestionarioService
    {
        IEnumerable<Cuestionario> ListarCuestionario();
        Task GuardarCuestionario(Cuestionario cuestionario);
        void EliminarCuestionario(Cuestionario cuestionario);
        Cuestionario ConsultarUnCuestionario(int id_cuestionario);
    }
    public class CuestionarioService : ICuestionarioService
    {
        CuestionarioContext _db;
        public CuestionarioService( CuestionarioContext db) {
        
            _db = db;
        }
        public IEnumerable<Cuestionario> ListarCuestionario()
        {
            return _db.Cuestionarios;
        }

        public async Task GuardarCuestionario(Cuestionario cuestionario)
        {
            _db.Cuestionarios.Add(cuestionario);
            await _db.SaveChangesAsync();
        }

        public Cuestionario ConsultarUnCuestionario(int id_cuestionario)
        {
            var cuestionario = _db.Cuestionarios.Find(id_cuestionario);
            return cuestionario;
        }

        public void EliminarCuestionario(Cuestionario cuestionario)
        {
            _db.Cuestionarios.Remove(cuestionario);
            _db.SaveChanges();
        }

        
    }
}
