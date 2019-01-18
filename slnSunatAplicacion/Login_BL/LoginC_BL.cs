using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_AD;
using Login_BE;

namespace Login_BL
{
    public class LoginC_BL
    {
        public int ValidarUsuario(int idusuario, string pass)
        {
            var objAD = new LoginC_AD();

            return objAD.ValidarUsuario(idusuario, pass);
        }

        public List<usp_Listarusuario_Result> ListarUsuario(int idusuario)
        {

            var objAD = new LoginC_AD();

            return objAD.ListarUsuario(idusuario).ToList();

        }


        public List<usp_ListarUsuarios_Result> ListarUsuarios()
        {

            var objAD = new LoginC_AD();
            return objAD.ListarUsuarios();

        }

        public string AdministrarUsuario(int idusuario, string nombre, string apellido, string cargo, int estado)
        {
            var objAD = new LoginC_AD();
            return objAD.AdministrarUsuario(idusuario, nombre, apellido, cargo, estado);
        }
        
    }
}
