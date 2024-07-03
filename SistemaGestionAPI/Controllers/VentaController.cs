using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult ObtenerVenta(int id)
        {
            try
            {
                Venta venta = VentaBusiness.ObtenerVenta(id);
                if (venta == null)
                {
                    return NotFound();
                }
                return Ok(venta);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet(Name = "TraerVentas")]
        public IActionResult Get()
        {
            try
            {
                var ventas = VentaBusiness.TraerVentas().ToArray();
                return Ok(ventas);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpDelete("{id}", Name = "EliminarVenta")]
        public IActionResult Delete(int id)
        {
            try
            {
                VentaBusiness.EliminarVenta(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPost("{idUsuario}", Name = "CargarVenta")]
        public IActionResult CargarVenta(int idUsuario, [FromBody] List<ProductoVendido> productosVendidos)
        {
            try
            {
                if (productosVendidos == null || !productosVendidos.Any())
                {
                    return BadRequest("Los datos de la venta no pueden ser nulos o vacíos");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                VentaBusiness.CargarVenta(productosVendidos, idUsuario);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
