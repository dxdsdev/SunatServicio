using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Sunat_BL;

namespace WcfService1SUNAT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Criptografia" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Criptografia.svc or Criptografia.svc.cs at the Solution Explorer and start debugging.
    public class Criptografia : ICriptografia
    {
        public string Desencriptar(string valor, string key)
        {
            var obj = new Cripto_BL();
            return obj.Desencriptar(valor, key);

        }

       

        public string Encriptar(string valor, string key)
        {
            var obj = new Cripto_BL();
            return obj.Encriptar(valor, key);
        }
    }
}
