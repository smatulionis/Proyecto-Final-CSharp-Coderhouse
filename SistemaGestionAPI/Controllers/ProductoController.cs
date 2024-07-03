using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult ObtenerProducto(int id)
        {
            try
            {
                Producto producto = ProductoBusiness.ObtenerProducto(id);
                if (producto == null)
                {
                    return NotFound(); 
                }
                return Ok(producto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpGet(Name = "TraerProductos")]
        public IActionResult Get()
        {
            try
            {
                var productos = ProductoBusiness.TraerProductos().ToArray();
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpDelete("{id}", Name = "EliminarProducto")]
        public IActionResult Delete(int id)
        {
            try
            {
                ProductoBusiness.EliminarProducto(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPut("{id}", Name = "ModificarProducto")]
        public IActionResult Put(int id, [FromBody] Producto producto)
        {
            try
            {
                ProductoBusiness.ModificarProducto(id, producto);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }

        [HttpPost(Name = "CrearProducto")]
        public IActionResult CrearProducto([FromBody] Producto producto)
        {
            try
            {
                if (producto == null)
                {
                    return BadRequest("El producto no puede ser nulo");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                ProductoBusiness.CrearProducto(producto);
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = ex.Message });
            }
        }
    }
}
