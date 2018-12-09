using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Criptografia;

namespace Sunat_AD
{
    public class Cripto_AD
    {

        public string Encriptar(string valor,string KEY) {

            var obj = new Criptografia.Criptografia();
            return obj.Encriptar(valor, KEY);

        }


        public string Desencriptar(string valor,string KEY)
        {
            var obj = new Criptografia.Criptografia();
            return obj.Desencriptar(valor, KEY);
        }
    }
}
