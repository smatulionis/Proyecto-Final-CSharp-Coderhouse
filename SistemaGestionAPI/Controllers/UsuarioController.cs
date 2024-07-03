using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult TraerUsuario(int id)
        {
            try
            {
                Usuario usuario = UsuarioBusiness.TraerUsuario(id);
                if (usuario == null)
                {
                    return NotFound();
                }
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet(Name = "ListarUsuarios")]
        public IActionResult Get()
        {
            try
            {
                var usuarios = UsuarioBusiness.ListarUsuarios().ToArray();
                return Ok(usuarios);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpDelete("{id}", Name = "EliminarUsuario")]
        public IActionResult Delete(int id)
        {
            try
            {
                UsuarioBusiness.EliminarUsuario(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPut("{id}", Name = "ModificarUsuario")]
        public IActionResult Put(int id, [FromBody] Usuario usuario)
        {
            try
            {
                UsuarioBusiness.ModificarUsuario(id, usuario);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPost(Name = "CrearUsuario")]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return BadRequest("El usuario no puede ser nulo");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                UsuarioBusiness.CrearUsuario(usuario);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
