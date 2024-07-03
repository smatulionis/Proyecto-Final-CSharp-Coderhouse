using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class Venta
    {
        private int id;
        private string comentarios;
        private int? idUsuario;
        public List<ProductoVendido> ProductosVendidos { get; set; }

        public Venta() { }

        public Venta(string comentarios, int? idUsuario)
        {
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }

        public Venta(int id, string comentarios, int? idUsuario) : this(comentarios, idUsuario)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }

        [Required(ErrorMessage = "El ID del usuario es obligatorio")]
        public int? IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
