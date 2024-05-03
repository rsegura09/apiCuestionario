using apiCuestionario.Models.Entities;
using apiCuestionario.Services;
using Microsoft.AspNetCore.Mvc;

namespace apiCuestionario.Controllers
{
    [ApiController]
    [Route("api/cuestionarios")]
    public class CuestionarioController : ControllerBase
    {
        private readonly ICuestionarioService _cuestionarioService;
        public CuestionarioController(ICuestionarioService cuestionarioService) {
            _cuestionarioService = cuestionarioService;
        }

        [HttpGet]
        public IActionResult ListarTodosLosCuestionarios()
        {
            if (_cuestionarioService.ListarCuestionario().Any())
            {
                return Ok(_cuestionarioService.ListarCuestionario());
            }else { return NotFound(); }   
        }

        [HttpGet("{id_cuestionario}")]
        public IActionResult ConsultarUnCuestionario(int id_cuestionario)
        {
            var cuestionario = _cuestionarioService.ConsultarUnCuestionario(id_cuestionario);

            if (cuestionario != null)
            {
                return Ok(cuestionario);
            }
            else { return NotFound(); }
        }

        [HttpPost]
        public IActionResult GuardarCuestionario([FromBody] Cuestionario cuestionario)
        {
            _cuestionarioService.GuardarCuestionario(cuestionario);
            return Ok(cuestionario);
        }

        [HttpDelete("{id_cuestionario}")]
        public IActionResult RemoverCuestionario(int id_cuestionario)
        {
            var cuestionarioEncontrado = _cuestionarioService.ConsultarUnCuestionario(id_cuestionario);
            if (cuestionarioEncontrado != null)
            {
                _cuestionarioService.EliminarCuestionario(cuestionarioEncontrado);
                return Ok();
            }else { return NotFound(); }
        }
    }
}
