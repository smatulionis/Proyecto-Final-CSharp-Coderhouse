using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public static class VentaData
    {
        public static Venta ObtenerVenta(int idVenta)
        {
            string query = @"
                SELECT 
                    v.Id AS VentaId,
                    v.Comentarios,
                    v.IdUsuario AS IdUsuarioVenta,
                    pv.Id AS ProductoVendidoId,
                    pv.Stock AS Cantidad,
                    pv.IdProducto as IdProductoProdVendido,
                    pv.IdVenta as IdVentaProdVendido
                FROM Venta v
                INNER JOIN ProductoVendido pv ON v.Id = pv.IdVenta
                WHERE v.Id = @idVenta
            ";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("@idVenta", SqlDbType.Int) { Value = idVenta });

                        Venta venta = null;

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                if (venta == null)
                                {
                                    venta = new Venta
                                    {
                                        Id = Convert.ToInt32(dr["VentaId"]),
                                        Comentarios = dr["Comentarios"].ToString(),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuarioVenta"]),
                                        ProductosVendidos = new List<ProductoVendido>()
                                    };
                                }

                                ProductoVendido productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(dr["ProductoVendidoId"]),
                                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                    IdProducto = Convert.ToInt32(dr["IdProductoProdVendido"]),
                                    IdVenta = Convert.ToInt32(dr["IdVentaProdVendido"])
                                };

                                venta.ProductosVendidos.Add(productoVendido);
                            }
                        }

                        return venta;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener la venta", ex);
                }
            }
        }

        public static List<Venta> TraerVentas()
        {
            List<Venta> lista = new List<Venta>();
            string query = @"
                SELECT 
                    v.Id AS VentaId,
                    v.Comentarios,
                    v.IdUsuario AS IdUsuarioVenta,
                    pv.Id AS ProductoVendidoId,
                    pv.Stock AS Cantidad,
                    pv.IdProducto as IdProductoProdVendido,
                    pv.IdVenta as IdVentaProdVendido
                FROM Venta v
                INNER JOIN ProductoVendido pv ON v.Id = pv.IdVenta
            ";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                try
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                int ventaId = Convert.ToInt32(dr["VentaId"]);
                                Venta venta = lista.FirstOrDefault(v => v.Id == ventaId);

                                if (venta == null)
                                {
                                    venta = new Venta
                                    {
                                        Id = ventaId,
                                        Comentarios = dr["Comentarios"].ToString(),
                                        IdUsuario = Convert.ToInt32(dr["IdUsuarioVenta"]),
                                        ProductosVendidos = new List<ProductoVendido>()
                                    };
                                    lista.Add(venta);
                                }

                                ProductoVendido productoVendido = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(dr["ProductoVendidoId"]),
                                    Cantidad = Convert.ToInt32(dr["Cantidad"]),
                                    IdProducto = Convert.ToInt32(dr["IdProductoProdVendido"]),
                                    IdVenta = Convert.ToInt32(dr["IdVentaProdVendido"])                                 
                                };

                                venta.ProductosVendidos.Add(productoVendido);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar las ventas", ex);
                }
            }
            return lista;
        }

        public static void EliminarVenta(int idVenta)
        {

            string obtenerProductosVendidosQuery = "SELECT IdProducto, Stock FROM ProductoVendido WHERE IdVenta = @IdVenta";
            string eliminarProductosVendidosQuery = "DELETE FROM ProductoVendido WHERE IdVenta = @IdVenta";
            string sumarStockQuery = "UPDATE Producto SET Stock = Stock + @Cantidad WHERE Id = @IdProducto";
            string eliminarVentaQuery = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {
                    List<ProductoVendido> productosVendidos = new List<ProductoVendido>();
                    using (SqlCommand comando = new SqlCommand(obtenerProductosVendidosQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = idVenta });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                productosVendidos.Add(new ProductoVendido
                                {
                                    IdProducto = Convert.ToInt32(dr["IdProducto"]),
                                    Cantidad = Convert.ToInt32(dr["Stock"])
                                });
                            }
                        }
                    }

                    foreach (var producto in productosVendidos)
                    {
                        using (SqlCommand comando = new SqlCommand(sumarStockQuery, conexion, transaction))
                        {
                            comando.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int) { Value = producto.Cantidad });
                            comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto });
                            comando.ExecuteNonQuery();
                        }
                    }

                    using (SqlCommand comando = new SqlCommand(eliminarProductosVendidosQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = idVenta });
                        comando.ExecuteNonQuery();
                    }

                    using (SqlCommand comando = new SqlCommand(eliminarVentaQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = idVenta });
                        comando.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al eliminar la venta", ex);
                }
            }
        }

        public static void CargarVenta(List<ProductoVendido> productos, int idUsuario)
        {

            int nuevaVentaId;
            string insertVentaQuery = "INSERT INTO Venta (Comentarios, IdUsuario) VALUES(@Comentarios, @IdUsuario); SELECT SCOPE_IDENTITY();";
            string insertProductosVendidosQuery = "INSERT INTO ProductoVendido (Stock, IdProducto, IdVenta) VALUES(@Stock, @IdProducto, @IdVenta);";
            string actualizarStockQuery = "UPDATE Producto SET Stock = Stock - @Cantidad WHERE Id = @IdProducto;";

            using (SqlConnection conexion = new SqlConnection(DatabaseConfig.ConnectionString))
            {
                conexion.Open();
                SqlTransaction transaction = conexion.BeginTransaction();

                try
                {

                    using (SqlCommand comando = new SqlCommand(insertVentaQuery, conexion, transaction))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = "Venta realizada" });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = idUsuario });

                        nuevaVentaId = Convert.ToInt32(comando.ExecuteScalar());
                    }

                    foreach (var producto in productos)
                    {
                        using (SqlCommand comando = new SqlCommand(insertProductosVendidosQuery, conexion, transaction))
                        {
                            comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Cantidad });
                            comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto });
                            comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = nuevaVentaId });

                            comando.ExecuteNonQuery();
                        }

                        using (SqlCommand comando = new SqlCommand(actualizarStockQuery, conexion, transaction))
                        {
                            comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto });
                            comando.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int) { Value = producto.Cantidad });

                            comando.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {

                    transaction.Rollback();
                    throw new Exception("Error al cargar la venta", ex);
                }
            }
        }

    }
}
