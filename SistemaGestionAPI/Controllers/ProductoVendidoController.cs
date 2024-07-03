using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "ListarProductosVendidos")]
        public IActionResult Get()
        {
            try
            {
                var productoVendidos = ProductoVendidoBusiness.ListarProductosVendidos().ToArray();
                return Ok(productoVendidos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet("{idUsuario}", Name = "TraerProductosVendidos")]
        public IActionResult Get(int idUsuario)
        {
            try
            {
                var productoVendidos = ProductoVendidoBusiness.TraerProductosVendidos(idUsuario).ToArray();
                return Ok(productoVendidos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
