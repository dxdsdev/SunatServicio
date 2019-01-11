using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


namespace WebFerreteria.App_Code
{
    public class LogTxT
    {
        public string CrearArchivo() {

            var pathLog =(ConfigurationManager.AppSettings["LOG_DIR"]);
            var pathFichero = ConfigurationManager.AppSettings["LOG_DIR_ARCHIVO"];

            
            

            return pathFicheroc;
        }
    }
}