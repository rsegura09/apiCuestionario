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
    }
}
