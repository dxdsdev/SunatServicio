using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_BE;
using Login_BL;

namespace WebExamen.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Mantenimiento()
        {
            List<usp_ListarUsuarios_Result> vlstUsuarios= new List<usp_ListarUsuarios_Result>();
            var objBL = new LoginC_BL();
            vlstUsuarios = objBL.ListarUsuarios().ToList();
            return View("Mantenimiento", vlstUsuarios);

            
        }

        public ActionResult IngresarUsuario()
        {
            
            return View();


        }



        public ActionResult ActualizarUsuario(string pId)
        {
            List<usp_Listarusuario_Result> vlstUsuario = new List<usp_Listarusuario_Result>();
            var objBL = new LoginC_BL();
            vlstUsuario = objBL.ListarUsuario(Convert.ToInt32(pId));
            return View("ActualizarUsuario", vlstUsuario);
        }

        [HttpPost]
        public ActionResult Administrar(string idusuario, string nombre, string apellido,string puesto, string estado)
        {
            var objBL = new LoginC_BL();
            string mensaje = objBL.AdministrarUsuario(Convert.ToInt32(idusuario), nombre, apellido, puesto, Convert.ToInt32(estado));

            Response.Redirect("~/Usuario/Mantenimiento");

            return View();
        }
    }
}
