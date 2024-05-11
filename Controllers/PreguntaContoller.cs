using apiCuestionario.Models.Entities;
using apiCuestionario.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCuestionario.Controllers
{
    [ApiController]
    [Route("api/pregunta")]
    public class PreguntaController : ControllerBase
    {
        private readonly IPreguntaService _preguntaService;

        public PreguntaController(IPreguntaService preguntaService)
        {
            _preguntaService = preguntaService;
        }

        [HttpGet]
        public IActionResult ListarPreguntas()
        {
            if(_preguntaService.ListarPreguntas().Any())
            {
                return Ok(_preguntaService.ListarPreguntas());
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public IActionResult GuardarPregunta([FromBody] Pregunta pregunta)
        {
            _preguntaService.GuardarPregunta(pregunta);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPregunta(int id)
        {
            var pregunta = _preguntaService.BuscarPregunta(id);
            if (pregunta != null)
            {
                return Ok(pregunta);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult BorrarPregunta(int id)
        {
            var pregunta = _preguntaService.BuscarPregunta(id);
            if(pregunta != null)
            {
                _preguntaService.EliminarPregunta(pregunta);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
