using apiCuestionario.Models.Entities;
using apiCuestionario.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCuestionario.Controllers
{
    [ApiController]
    [Route("api/respuesta")]
    public class RespuestaController: ControllerBase
    {
        private readonly IRespuestaService _respuestaService;
        public RespuestaController(IRespuestaService respuestaService)
        {
            _respuestaService = respuestaService;
        }

        [HttpGet]
        public IActionResult ListarRespuestas() {
            if(_respuestaService.ListarRespuestas().Any())
            {
                return Ok(_respuestaService.ListarRespuestas());
            }
            else { return NotFound(); }
        }

        [HttpPost]
        public IActionResult GuardarPregunta([FromBody] Respuesta respuesta) {
            _respuestaService.GuardarRespuesta(respuesta);
            return Ok();
        }
    }
}
