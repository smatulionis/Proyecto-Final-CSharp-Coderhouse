using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public static class DatabaseConfig
    {
        public static readonly string ConnectionString = @"Server=localhost\SQLEXPRESS;Database=SistemaGestion;Trusted_Connection=True;";
    }

    public static class ProductoData
    {
        public static Producto ObtenerProducto(int idProducto)
        {
            string query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto WHERE Id=@idProducto";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("idProducto", SqlDbType.BigInt) { Value = idProducto });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows && dr.Read())
                            {
                                return new Producto
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Costo = Convert.ToDouble(dr["Costo"]),
                                    PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]),
                                    Stock = Convert.ToInt32(dr["Stock"]),
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener el producto", ex);
                }
            }
            return null;
        }

        public static List<Producto> TraerProductos()
        {
            List<Producto> lista = new List<Producto>();
            string query = "SELECT Id, Descripcion, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

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
                                lista.Add(new Producto
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Descripcion = dr["Descripcion"].ToString(),
                                    Costo = Convert.ToDouble(dr["Costo"]),
                                    PrecioVenta = Convert.ToDouble(dr["PrecioVenta"]),
                                    Stock = Convert.ToInt32(dr["Stock"]),
                                    IdUsuario = Convert.ToInt32(dr["IdUsuario"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los productos", ex);
                }
            }
            return lista;
        }

        public static void CrearProducto(Producto producto)
        {          
            string query = "INSERT INTO Producto (Descripcion, Costo, PrecioVenta, Stock, IdUsuario) VALUES(@Descripcion, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al crear el producto", ex);
                }
            }
        }

        public static void ModificarProducto(int id, Producto producto)
        {
            string query = "UPDATE Producto SET Descripcion = @Descripcion, Costo = @Costo, PrecioVenta = @PrecioVenta, Stock = @Stock, IdUsuario = @IdUsuario WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = id });
                        comando.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });
                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar el producto", ex);
                }
            }
        }

        public static void EliminarProducto(int idProducto)
        {

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                SqlTransaction transaction = null;
                try
                {
                    conexion.Open();
                    transaction = conexion.BeginTransaction();

                    using (SqlCommand comandoProductoVendido = new SqlCommand("DELETE FROM ProductoVendido WHERE IdProducto = @IdProducto", conexion, transaction))
                    {
                        comandoProductoVendido.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = idProducto });
                        comandoProductoVendido.ExecuteNonQuery();
                    }

                    using (SqlCommand comandoProducto = new SqlCommand("DELETE FROM Producto WHERE Id = @Id", conexion, transaction))
                    {
                        comandoProducto.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = idProducto });
                        comandoProducto.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        transaction.Rollback();
                    }
                    throw new Exception("Error al eliminar el producto y sus referencias", ex);
                }
            }
        }
    }
}
