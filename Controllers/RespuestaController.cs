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
            return NotFound();
        }

        [HttpPost]
        public IActionResult GuardarRespuesta([FromBody] Respuesta respuesta) {
            _respuestaService.GuardarRespuesta(respuesta);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarRespuesta(int id)
        {
            var respuesta = _respuestaService.BuscarRespuesta(id);
            if(respuesta != null)
            {
                return Ok(respuesta);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarRespuesta(int id)
        {
            var respuesta = _respuestaService.BuscarRespuesta(id);
            if (respuesta != null)
            {
                _respuestaService.EliminarRespuesta(respuesta);
                return Ok();
            }
            return NotFound();
        }
    }
}
