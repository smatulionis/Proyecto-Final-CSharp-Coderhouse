using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class UsuarioData
    {
        public static Usuario TraerUsuario(int idUsuario)
        {
            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id=@idUsuario";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.BigInt) { Value = idUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows && dr.Read())
                            {
                                return new Usuario
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Apellido = dr["Apellido"].ToString(),
                                    NombreUsuario = dr["NombreUsuario"].ToString(),
                                    Contrasenia = dr["Contraseña"].ToString(),
                                    Mail = dr["Mail"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el usuario", ex);
                }
            }
            return null;
        }

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.HasRows && dr.Read())
                            {
                                lista.Add(new Usuario
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Nombre = dr["Nombre"].ToString(),
                                    Apellido = dr["Apellido"].ToString(),
                                    NombreUsuario = dr["NombreUsuario"].ToString(),
                                    Contrasenia = dr["Contraseña"].ToString(),
                                    Mail = dr["Mail"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los usuarios", ex);
                }
            }
            return lista;
        }

        public static void CrearUsuario(Usuario usuario)
        {
            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el usuario", ex);
                }
            }
        }

        public static void ModificarUsuario(int id, Usuario usuario)
        {
            string query = "UPDATE Usuario SET Nombre = @Nombre, Apellido = @Apellido, NombreUsuario = @NombreUsuario, Contraseña = @Contraseña, Mail = @Mail WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar el usuario", ex);
                }
            }
        }

        public static void EliminarUsuario(int idUsuario)
        {
            string obtenerVentasQuery = "SELECT Id FROM Venta WHERE IdUsuario = @IdUsuario";
            string eliminarProductoQuery = "DELETE FROM Producto WHERE IdUsuario = @IdUsuario";
            string eliminarUsuarioQuery = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {

                    List<int> ventasIds = new List<int>();
                    using (SqlCommand comando = new SqlCommand(obtenerVentasQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = idUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                ventasIds.Add(Convert.ToInt32(dr["Id"]));
                            }
                        }
                    }

                    foreach (var idVenta in ventasIds)
                    {
                        VentaData.EliminarVenta(idVenta, conexion, transaction);
                    }

                    using (SqlCommand comandoProducto = new SqlCommand(eliminarProductoQuery, conexion, transaction))
                    {
                        comandoProducto.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = idUsuario });
                        comandoProducto.ExecuteNonQuery();
                    }

                    using (SqlCommand comando = new SqlCommand(eliminarUsuarioQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = idUsuario });
                        comando.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al eliminar el usuario", ex);
                }
            }
        }








    }
}
