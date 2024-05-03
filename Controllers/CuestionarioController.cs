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
        public IActionResult Get()
        {
            if (_cuestionarioService.Get().Any())
            {
                return Ok(_cuestionarioService.Get());
            }else { return NotFound(); }   
        }
    }
}
