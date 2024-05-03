using apiCuestionario.Models.Entities;

namespace apiCuestionario.Services
{
    public interface ICuestionarioService
    {
        public IEnumerable<Cuestionario> Get();
    }
    public class CuestionarioService : ICuestionarioService
    {
        CuestionarioContext _db;
        public CuestionarioService( CuestionarioContext db) {
        
            _db = db;
        }
        public IEnumerable<Cuestionario> Get()
        {
            return _db.Cuestionarios;
        }
    }
}
