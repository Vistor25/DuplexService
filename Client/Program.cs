using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            CallBack call = new CallBack();
            call.CallService();
            Console.Read();
            call.Dispose();
        }
    }
}
