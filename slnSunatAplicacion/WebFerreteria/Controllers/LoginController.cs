using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFerreteria.SRVCriptografia;
using WebFerreteria.SVRsunat;
using Ferreteria_BL;


namespace WebFerreteria.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Index()
        {
            string pFichero = string.Empty;
            ViewBag.Archivo = CreaLog(ref pFichero);
            ViewBag.Fichero = pFichero;
            GuardarMensaje("Hay examennnnn el jueves y presenetacion de tare", pFichero);
            return View();
        }

        private string CreaLog(ref string pFichero)
        {
            LogTXT objtxt = new LogTXT();
            return objtxt.CrearArchivo(ref pFichero);
        }

        private string GuardarMensaje(string pMensaje, string pFichero)
        {
            LogTXT objtxt = new LogTXT();
            return objtxt.EscribirLog(pMensaje, pFichero);
        }

        /*
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.Archivo = CreaLog();
            return View();
        }

        private string CreaLog(ref string pFichero) {
            LogTxT objtxt = new LogTxT();

            return objtxt.CrearArchivo(ref pFichero);
        }
        */
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