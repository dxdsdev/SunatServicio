using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ferreteria_BE;

namespace Ferreteria_AD
{
    public class Producto_AD
    {
        public string AdministrarProducto(int pIdProducto, string pDescripcion, int pTipoProducto, int pEstado, string pUsuario) {
            
            string vRespuesta = "Producto Actualizado";
            try
            {
                var bd = new BD_FerreteriaEntities();
                bd.Usp_AdministrarProducto(pIdProducto, pDescripcion, pTipoProducto, pEstado, pUsuario);
                if (pIdProducto==0)
                {
                    vRespuesta = "Producto Agregado";
                }
                return vRespuesta;
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }

        public List<Usp_ObtenerProductos_Result> ObtenerProductos() {
            var bd = new BD_FerreteriaEntities();
            return bd.Usp_ObtenerProductos().ToList();
        }

    }
}
