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

        public ActionResult EditarProducto(string pId)
        {
            List<Usp_ObtenerProductos_Result> vlstProducto = new List<Usp_ObtenerProductos_Result>();
            var objBL = new Ferreteria_BL.Producto_BL();
            vlstProducto = objBL.ObtenerProductos().ToList();

            return View("EditarProducto", vlstProducto);
        }
    }
}