using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;



namespace Ferreteria_BL
{
    public class LogTXT
    {
        public string CrearArchivo(ref string vFichero)
        {
            try
            {
                string vCarpetaLog =
                ConfigurationManager.AppSettings["RutaLog"].ToString();
                vFichero = string.Concat(vCarpetaLog,ConfigurationManager.AppSettings["NombreArchivoLog"].ToString(),"_",DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                string vretorno = string.Empty;
                if (File.Exists(vFichero))
                {
                    vretorno = "Archivo Existente";
                }
                else
                {
                    File.Create(vFichero);
                    vretorno = "Archivo Creado";
                }

                return vretorno;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }

        public string EscribirLog(string pMensaje,
            string pFichero)
        {
            try
            {
                TextWriter sw =
                    new StreamWriter(pFichero, true);
                sw.WriteLine(DateTime.Now + "|" + pMensaje);
                sw.Close();
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
    }

    /*public class LogTxT
    {
        public string CrearArchivo(ref string vpathFichero)
        {

            try
            {
                
                var pathLog = (ConfigurationManager.AppSettings["LOG_DIR"]);
                var pathFichero = ConfigurationManager.AppSettings["LOG_DIR_ARCHIVO"];

                var pathLogc = ConfigurationManager.AppSettings["LOG_DIRC"];
                var pathFicheroc = ConfigurationManager.AppSettings["LOG_DIRC_ARCHIVO"];

                if (File.Exists(pathFichero)){
                    return "El Archivo ya Existe";
                }
                else {
                    File.Create(pathFichero);
                    return "Archivo Creado";
                }
                
            }
            catch (Exception e)
            {

                return e.Message.ToString();
            }
        }
    }*/


}
