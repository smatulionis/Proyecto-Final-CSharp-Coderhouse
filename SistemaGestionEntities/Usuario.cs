using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contrasenia;
        private string mail;

        public Usuario() { }

        public Usuario(string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contrasenia = contrasenia;
            this.mail = mail;
        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail) : this(nombre, apellido, nombreUsuario, contrasenia, mail)
        {
            this.id = id;
        }

        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get => nombre; set => nombre = value; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        public string Apellido { get => apellido; set => apellido = value; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }

        [Required(ErrorMessage = "El mail es obligatorio")]
        public string Mail { get => mail; set => mail = value; }
    }
}
