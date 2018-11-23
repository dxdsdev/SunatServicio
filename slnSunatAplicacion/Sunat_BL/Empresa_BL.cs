using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_AD;
using Sunat_BE;

namespace Sunat_BL
{
   public class Empresa_BL
    {
        
        public List<ObtenerEmpresaTodas_Result> ObtenerListaEmpresas()
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.ObtenerListaEmpresas();
        }

        public List<ObtenerEmpresa_Result> ObtenerEmpresa(string pIdempresa, string pLlave)            
        {
            Empresa_AD objAD = new Empresa_AD();
            return objAD.ObtenerEmpresa(pIdempresa, pLlave);
        }
        public string AgregarEmpresa(String pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            var objAD = new Empresa_AD();
            return objAD.AgregarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);

        }
        public string EditarEmpresa(String pIdEmpresa, string pNombre, string pLlave, int pEstado)
        {
            var objAD = new Empresa_AD();
            return objAD.EditarEmpresa(pIdEmpresa, pNombre, pLlave, pEstado);

        }

        public string EliminarEmpresa(String pIdEmpresa)
        {
            var objAD = new Empresa_AD();
            return objAD.EliminarEmpresa(pIdEmpresa);

        }


    }


}
