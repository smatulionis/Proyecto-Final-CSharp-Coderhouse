using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class Producto
    {
        private int id;
        private string descripcion;
        private double costo;
        private double? precioVenta;
        private int? stock;
        private int? idUsuario;

        public Producto() { }

        public Producto(string descripcion, double costo, double? precioVenta, int? stock, int? idUsuario)
        {
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }

        public Producto(int id, string descripcion, double costo, double? precioVenta, int? stock, int? idUsuario) : this(descripcion, costo, precioVenta, stock, idUsuario)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        
        public double Costo { get => costo; set => costo = value; }

        [Required(ErrorMessage = "El precio de venta es obligatorio")]
        public double? PrecioVenta { get => precioVenta; set => precioVenta = value; }

        [Required(ErrorMessage = "El stock es obligatorio")]
        public int? Stock { get => stock; set => stock = value; }

        [Required(ErrorMessage = "El ID del usuario es obligatorio")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
