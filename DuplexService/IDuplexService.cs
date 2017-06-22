using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DuplexService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(ICallBackContract))]
    public interface IDuplexService
    {
        // TODO: Add your service operations here
        [OperationContract(IsOneWay = true)]
        void NormalFunction();
    }
    
    public interface ICallBackContract
    {
        [OperationContract(IsOneWay = true)]
        void CallBackFunction(string data);
    }
}
