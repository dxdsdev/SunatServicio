using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFerreteria.App_Code
{
    public class Utilitarios
    {
        public string GeneraToken() {
            return Guid.NewGuid().ToString();
        }

        public string ObtenerLlave() {
            return null;
        }

    }
}