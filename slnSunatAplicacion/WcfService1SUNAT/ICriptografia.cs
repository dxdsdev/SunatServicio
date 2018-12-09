using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1SUNAT
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICriptografia" in both code and config file together.
    [ServiceContract]
    public interface ICriptografia
    {
        
        [OperationContract]
        string Encriptar(string valor,string key);

        [OperationContract]
        string Desencriptar(string valor, string key);


    }
}
