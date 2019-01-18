using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Login_BE;
using Login_BL;

namespace WcfServiceLogin
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int ValidarUsuario(int username, string pass);

        [OperationContract]
        List<usp_Listarusuario_Result> ListarUsuario(int idusuario);

        [OperationContract]
        List<usp_ListarUsuarios_Result> ListarUsuarios();
    }


    
}

