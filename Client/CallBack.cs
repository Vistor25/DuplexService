using System;
using System.ServiceModel;
using System.Threading.Tasks;
using Client.ServiceReference;
using DuplexService;

namespace Client
{
    public class CallBack : IDuplexServiceCallback, IDisposable
    {
        DuplexServiceClient client;
        public void CallBackFunction(string data)
        {
            Console.WriteLine(data);
        }
        public void CallService()
        {
            InstanceContext context = new InstanceContext(this);
            client = new DuplexServiceClient(context);
            client.NormalFunction();
            
        }
        public void Dispose()
        {
            client.Close();
        }
    }
}