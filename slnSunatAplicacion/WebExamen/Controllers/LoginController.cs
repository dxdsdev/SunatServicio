using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExamen.ServiceReference1;

namespace WebExamen.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }

        public ActionResult ValidarLogin(string idusuario,string pass)
        {


            int vallogin = 0;
            Service1Client objServic = new Service1Client();

            vallogin = objServic.ValidarUsuario(Convert.ToInt32(idusuario),pass);
            if (vallogin != 0)
            {
                Response.Redirect("~/Usuario/Mantenimiento");
            }
            else {
                Response.Redirect("~/Login/Error");
            }


            return View();
        }
    }
}