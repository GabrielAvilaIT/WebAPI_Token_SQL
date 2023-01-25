using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Token_SQL.Models.Request;
using WebAPI_Token_SQL.Models.Response;
using WebAPI_Token_SQL.Services;

namespace WebAPI_Token_SQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public IActionResult Autentificar([FromBody] AuthRequest model)
        {
            Respuesta respuesta = new Respuesta();

            var userresponse = _userService.Auth(model);

            if (userresponse == null)
            {
                respuesta.Exito = 0;
                respuesta.Mensaje = "Usuario o Contraseña Incorrecto";

                return BadRequest(respuesta);
            }

            respuesta.Exito = 1;

            respuesta.Data = userresponse;

            return Ok(respuesta);
        }

    }
}
