using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Login_BE;
using Login_BL;

namespace WcfServiceLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int ValidarUsuario(int idusuario, string pass)
        {
            var objbl = new LoginC_BL();

            return objbl.ValidarUsuario(idusuario, pass);
        }

        public List<usp_Listarusuario_Result> ListarUsuario(int idusuario)
        {

            var objbl = new LoginC_BL();
            return objbl.ListarUsuario(idusuario).ToList();

        }


        public List<usp_ListarUsuarios_Result> ListarUsuarios()
        {

            var objbl = new LoginC_BL();
            return objbl.ListarUsuarios();

        }

        
    }
}
