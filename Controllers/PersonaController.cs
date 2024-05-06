using apiCuestionario.Models.Entities;
using apiCuestionario.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCuestionario.Controllers
{
    [ApiController]
    [Route("api/persona")]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        public PersonaController(IPersonaService cuestionarioService)
        {
            _personaService = cuestionarioService;
        }

        [HttpGet]
        public IActionResult ListarPersonas()
        {
            if (_personaService.ListarPersona().Any())
            {
                return Ok(_personaService.ListarPersona());
            }
            else { return NotFound(); }
        }

        [HttpPost]
        public IActionResult GuardarPersona([FromBody] Persona persona)
        {
            _personaService.GuardarPersona(persona);
            return Ok(persona);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPersona(int id)
        {
            var Persona = _personaService.BuscarPersona(id);

            if (Persona == null)
            {
                return NotFound();
            }
            return Ok(Persona);
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarPersona(int id)
        {
            var PersonaBuscada = _personaService.BuscarPersona(id);
            if (PersonaBuscada == null)
            {
                return NotFound();
            }
            else
            {
                _personaService.EliminarPersona(PersonaBuscada);
                return Ok();
            }
        }
    }
}
