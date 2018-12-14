using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFerreteria.SVRsunat;

namespace WebFerreteria.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegistrarUsuario(string pIdUsuario, string pNombre, string pApellido, string pClave)
        {
            var objServ = new Service1Client();
            string msj = objServ.RegistrarUsuario(pIdUsuario, pNombre, pApellido, pClave);

            return View();
        }

    }
}