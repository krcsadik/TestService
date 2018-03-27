using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace TestServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(TestService.Service1)))
            {
                host.Open();
                Console.WriteLine("My Demo Service started : " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
