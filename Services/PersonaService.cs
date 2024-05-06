using apiCuestionario.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace apiCuestionario.Services
{
    public interface IPersonaService
    {
        IEnumerable<Persona> ListarPersona();
        Task GuardarPersona(Persona persona);
        void EliminarPersona(Persona persona);
        Persona BuscarPersona(int id);
    }
    public class PersonaService : IPersonaService
    {
        CuestionarioContext _db;
        public PersonaService(CuestionarioContext db)
        {

            _db = db;
        }

        public IEnumerable<Persona> ListarPersona()
        {
            return _db.Personas;
        }

        public async Task GuardarPersona(Persona persona)
        {
            _db.Personas.Add(persona);
            await _db.SaveChangesAsync();
        }

        public Persona BuscarPersona(int id)
        {
            var persona = _db.Personas.Find(id);
            return persona;
        }

        public void EliminarPersona(Persona persona)
        {
            _db.Personas.Remove(persona);
            _db.SaveChanges();
        }
    }
}
