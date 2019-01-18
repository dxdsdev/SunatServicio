using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login_BE;

namespace Login_AD
{
    public class LoginC_AD
    {
        public int ValidarUsuario(int idusuario, string pass)
        {
            var db = new Examen_NombreApellidoEntities();

            return Convert.ToInt16(db.Sp_Login(idusuario, pass).FirstOrDefault());
        }

        public List<usp_Listarusuario_Result> ListarUsuario(int idusuario)
        {

            var db = new Examen_NombreApellidoEntities();

            return db.usp_Listarusuario(idusuario).ToList();

        }


        public List<usp_ListarUsuarios_Result>  ListarUsuarios( )
        {

            var db = new Examen_NombreApellidoEntities();

            return db.usp_ListarUsuarios().ToList();

        }

        public string AdministrarUsuario(int idusuario, string nombre, string apellido, string cargo, int estado)
        {

            string vRespuesta = "Usuario Actualizado";
            try
            {
                var bd = new Examen_NombreApellidoEntities();
                bd.Usp_AdministrarUsuario(idusuario, nombre, apellido, cargo, estado);
                if (idusuario == 0)
                {
                    vRespuesta = "Usuario Agregado";
                }
                return vRespuesta;
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
        }




    }



}
