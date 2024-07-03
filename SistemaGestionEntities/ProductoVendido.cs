using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class ProductoVendido
    {
        private int id;
        private int? cantidad;
        private int? idProducto;
        private int idVenta;

        public ProductoVendido() { }
        public ProductoVendido(int? cantidad, int? idProducto, int idVenta)
        {
            this.cantidad = cantidad;
            this.idProducto = idProducto;
            this.idVenta = idVenta;
        }

        public ProductoVendido(int id, int? cantidad, int? idProducto, int idVenta) : this(cantidad, idProducto, idVenta)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        public int? Cantidad { get => cantidad; set => cantidad = value; }

        [Required(ErrorMessage = "El ID del producto es obligatorio")]
        public int? IdProducto { get => idProducto; set => idProducto = value; }

        public int IdVenta { get => idVenta; set => idVenta = value; }
    }
}
