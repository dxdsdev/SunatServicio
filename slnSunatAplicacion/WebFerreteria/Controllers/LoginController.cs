using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFerreteria.SRVCriptografia;
using WebFerreteria.SVRsunat;


namespace WebFerreteria.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Ingreso(string idUsuario,string Password)
        {
            var objCripto = new CriptografiaClient();
            string passwordEncriptada = objCripto.Encriptar(Password,"IDAT");


            var objServ = new Service1Client();
            string ptoken = objServ.Login(idUsuario, passwordEncriptada, "IDAT");

            Session.Add("SessionToken", ptoken);
            Response.Write(Session["SessionToken"].ToString());

            /*ViewBag.pToken = ptoken;
            ViewBag.Pass = passwordEncriptada;*/
            return View();
        }


    }
}