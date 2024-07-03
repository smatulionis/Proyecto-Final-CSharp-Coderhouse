using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class VentaBusiness
    {
        public static Venta ObtenerVenta(int idVenta)
        {
            return VentaData.ObtenerVenta(idVenta);
        }

        public static List<Venta> TraerVentas()
        {
            return VentaData.TraerVentas();    
        }

        public static void EliminarVenta(int idVenta)
        {
            VentaData.EliminarVenta(idVenta);
        }

        public static void CargarVenta(List<ProductoVendido> productos, int idUsuario)
        {
            VentaData.CargarVenta(productos, idUsuario);
        }
    }
}
