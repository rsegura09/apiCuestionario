using apiCuestionario.Models.Entities;
using apiCuestionario.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCuestionario.Controllers
{
    [ApiController]
    [Route("api/respuesta/usuario")]
    public class RespuestaUsuarioController : ControllerBase
    {
        private readonly IRespuestaUsuarioService _respuestaUsuarioService;
        public RespuestaUsuarioController(IRespuestaUsuarioService respuestaService)
        {
            _respuestaUsuarioService = respuestaService;
        }

        [HttpGet]
        public IActionResult ListarRespuestasUsuarios()
        {
            if (_respuestaUsuarioService.ListarRespuestaUsuario().Any())
            {
                return Ok(_respuestaUsuarioService.ListarRespuestaUsuario());
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult RespuestasUsuarios([FromBody] RespuestaUsuario respuestaUsuario)
        {
            _respuestaUsuarioService.GuardarRespuestaUsuario(respuestaUsuario);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult BuscarRespuestasUsuarios(int id)
        {
            var respuestaUsuario = _respuestaUsuarioService.BuscarRespuestaUsuario(id);
            if (respuestaUsuario != null)
            {
                return Ok(respuestaUsuario);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarRespuestasUsuarios(int id)
        {
            var respuestaUsuario = _respuestaUsuarioService.BuscarRespuestaUsuario(id);
            if (respuestaUsuario != null)
            {
                _respuestaUsuarioService.EliminarRespuestaUsuario(respuestaUsuario);
                return Ok();
            }
            return NotFound();
        }
    }
}
