using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_BE;
using Criptografia;

namespace Sunat_AD
{
    public class Usuario_AD
    {
        public int ValidarUsuario(string username,string pass ) {
            var db = new BD_Sunat1Entities();

            return Convert.ToInt16(db.ValidarUsuario(username, pass).FirstOrDefault());
        }

        public ObtenerUsuario_Result ObtenerUsuario(string username) {

            var db = new BD_Sunat1Entities();

            return db.ObtenerUsuario(username).FirstOrDefault();

        }
        
        /*
        public string Login(string pUsuario, string pClave,string pToken)
        {

            try
            {
                var db = new BD_Sunat1Entities();
                return db.Sp_Login_Token(pUsuario,pClave,pToken).FirstOrDefault();
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            

            
        }*/

        public string Login(string pusuario, string pClave,string KEY)
        {
            Criptografia.Criptografia objCripto = new Criptografia.Criptografia();
            
            string pResult;
            try
            {
                using (var db = new BD_Sunat1Entities())
                {
                    string tokenEncriptado = objCripto.Encriptar(Guid.NewGuid().ToString(), KEY);

                    pResult = db.Sp_Login_Token(pusuario, pClave,tokenEncriptado).FirstOrDefault();

                    
                    return pResult;
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }



    }
}
