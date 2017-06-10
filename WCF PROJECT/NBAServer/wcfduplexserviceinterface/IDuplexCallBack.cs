using System.ServiceModel;

/* Callback Contract specifies the operations that a service can invoke on a client. */

namespace WcfDuplexServiceInterface
{
    
    public interface IDuplexCallBack
    {
        [OperationContract(IsOneWay = true)]
        void broadcastUpdate(string item,string caption);
    }
}

