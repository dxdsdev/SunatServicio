using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ferreteria_BL;
using Ferreteria_BE;

namespace WebFerreteria.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Mantenimiento()
        {

            List<Usp_ObtenerProductos_Result> vlstProducto = new List<Usp_ObtenerProductos_Result>();
            var objBL = new Ferreteria_BL.Producto_BL();
            vlstProducto = objBL.ObtenerProductos().ToList();
            return View("Mantenimiento", vlstProducto);

        }

        public ActionResult EditarProducto(int pId)
        {
            List<Usp_ObtenerProductoById_Result> vlstProducto = new List<Usp_ObtenerProductoById_Result>();
            var objBL = new Ferreteria_BL.Producto_BL();
            vlstProducto = objBL.ObtenerProductosById(pId).ToList();

            return View("EditarProducto", vlstProducto);
        }

        [HttpPost]
        public ActionResult Administrar(string Id, string Descripcion, string TipoProducto, string Estado)
        {
            var objBL = new Ferreteria_BL.Producto_BL();
            
            string mensaje=objBL.AdministrarProducto(Convert.ToInt32(Id), Descripcion, Convert.ToInt32(TipoProducto), Convert.ToInt32(Estado), "croweloper");
            
            

            Response.Redirect("~/Producto/Mantenimiento?"+ Id);

            return View();
        }
    }
}