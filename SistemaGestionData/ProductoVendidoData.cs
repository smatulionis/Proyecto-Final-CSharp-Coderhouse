using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class ProductoVendidoData
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

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
                                lista.Add(new ProductoVendido
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Cantidad = Convert.ToInt32(dr["Stock"]),
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    IdVenta = Convert.ToInt32(dr["IdVenta"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los productos vendidos", ex);
                }
            }
            return lista;
        }

        public static List<ProductoVendido> TraerProductosVendidos(int idUsuario)
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string query = @"
                SELECT pv.Id, pv.Stock, pv.IdProducto, pv.IdVenta
                FROM ProductoVendido pv
                INNER JOIN Venta v ON pv.IdVenta = v.Id
                WHERE v.IdUsuario = @IdUsuario";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = idUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.HasRows && dr.Read())
                            {
                                lista.Add(new ProductoVendido
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Cantidad = Convert.ToInt32(dr["Stock"]),
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    IdVenta = Convert.ToInt32(dr["IdVenta"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar los productos vendidos", ex);
                }
            }
            return lista;
        }  
    }
}
