using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebFerreteria.SVRsunat;

namespace WebFerreteria.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            List<ObtenerEmpresaTodas_Result> vlstEmpresa = new List<ObtenerEmpresaTodas_Result>();
            Service1Client objServic = new Service1Client();
            vlstEmpresa = objServic.ObtenerListaEmpresas().ToList();

            return View("index" , vlstEmpresa);
        }

        public ActionResult EditarEmpresa(string pIdEmpresa,string pKey)
        {
            List<ObtenerEmpresa_Result> vlstEmpresa = new List<ObtenerEmpresa_Result>();
            Service1Client objServic = new Service1Client();
            vlstEmpresa = objServic.ObtenerEmpresa(pIdEmpresa,pKey).ToList();

            return View("EditarEmpresa", vlstEmpresa);
        }

       

    }
}