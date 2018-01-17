using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace FizzBuzzWithWcf.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(CheckFizzBuzzService));
            serviceHost.Open();

            Console.WriteLine("Now listening in");
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
