using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_AD;
using Ferreteria_BE;

namespace Ferreteria_BL
{
    public class Producto_BL
    {
        public string AdministrarProducto(int pIdProducto,string pDescripcion, int pTipoProducto, int pEstado,string pUsuario)
        {
            var objAD = new Producto_AD();
            return objAD.AdministrarProducto(pIdProducto,pDescripcion, pTipoProducto, pEstado, pUsuario);
        }

        public List<Usp_ObtenerProductos_Result> ObtenerProductos()
        {
            var objAD = new Producto_AD();
            return objAD.ObtenerProductos();
        }

        public List<Usp_ObtenerProductoById_Result> ObtenerProductosById(int pId)
        {
            var objAD = new Producto_AD();
            return objAD.ObtenerProductosById(pId).ToList();
        }
    }
}
