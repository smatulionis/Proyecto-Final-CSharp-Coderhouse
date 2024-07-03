using SistemaGestionData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public static class ProductoVendidoBusiness
    {
        public static List<ProductoVendido> ListarProductosVendidos()
        {
            return ProductoVendidoData.ListarProductosVendidos();
        }

        public static List<ProductoVendido> TraerProductosVendidos(int idUsuario)
        {
            return ProductoVendidoData.TraerProductosVendidos(idUsuario);
        }
    }
}
