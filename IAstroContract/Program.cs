using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//Poorav Sharma 
//30045900
//ServiceHost and NetNamedPipeBinding in the “Program.cs” file to provide connection for the client(s). A Console.ReadLine is added to pause the program during operation.
namespace IAstroContract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string address = "net.pipe://localhost/astro_math";
            ServiceHost serviceHost = new ServiceHost(typeof(AstroServer));
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address);
            serviceHost.Open();
            Console.WriteLine("ServiceHost is running. Press <<Enter>> to Exit");
            Console.ReadLine();
            serviceHost.Close();
        }
    }
}
