using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class UsuarioBusiness
    {
        public static Usuario TraerUsuario(int idUsuario)
        {
            return UsuarioData.TraerUsuario(idUsuario);
        }

        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static void CrearUsuario(Usuario usuario)
        {          
            var usuariosExistentes = ListarUsuarios();
            if (usuariosExistentes.Any(u => u.NombreUsuario.Equals(usuario.NombreUsuario, StringComparison.OrdinalIgnoreCase)))
            {
                throw new Exception("El nombre de usuario ya está en uso.");
            }

            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(int id, Usuario usuario)
        {
            UsuarioData.ModificarUsuario(id, usuario);
        }

        public static void EliminarUsuario(int idUsuario)
        {
            UsuarioData.EliminarUsuario(idUsuario);
        }
    }
}
