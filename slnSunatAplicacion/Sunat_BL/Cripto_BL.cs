using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunat_AD;

namespace Sunat_BL
{
    public class Cripto_BL
    {

        public string Encriptar(string valor, string KEY) {

            var obj = new Cripto_AD();

            return obj.Encriptar(valor, KEY);
        }

        public string Desencriptar(string valor, string KEY)
        {

            var obj = new Cripto_AD();

            return obj.Desencriptar(valor, KEY);
        }


    }
}
