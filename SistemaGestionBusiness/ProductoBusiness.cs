using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class ProductoBusiness
    {
        public static Producto ObtenerProducto(int idProducto)
        {
            return ProductoData.ObtenerProducto(idProducto);
        }

        public static List<Producto> TraerProductos()
        {
            return ProductoData.TraerProductos();
        }

        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(int id, Producto producto)
        {
            ProductoData.ModificarProducto(id, producto);
        }

        public static void EliminarProducto(int idProducto)
        {
            ProductoData.EliminarProducto(idProducto);
        }
    }
}
