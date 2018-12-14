using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_BE;
using Sunat_AD;

namespace Sunat_BL
{
    public class Usuario_BL
    {
        public int ValidarUsuario(string username, string pass) {
            var objSunat = new Usuario_AD();
            return objSunat.ValidarUsuario(username,pass);
        }


        public string Login(string pUsuario, string pClave,string key)
        {
            var objSunat = new Usuario_AD();
            return objSunat.Login(pUsuario, pClave,key);
        }

        public ObtenerUsuario_Result ObtenerUsuario(string username)
        {
            var objSunat = new Usuario_AD();
            return objSunat.ObtenerUsuario(username);

        }

        public string RegistrarUsuario(string pIdUsuario, string pNombre, string pApellido, string pClave) {
            var objSunat = new Usuario_AD();
            return objSunat.RegistrarUsuario(pIdUsuario,pNombre,pApellido,pClave);
        }



    }
}
