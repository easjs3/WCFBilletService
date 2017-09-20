using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFBilletClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new BilletService.BilletClient("BasicHttpsBinding_IBillet"))
            {
                Console.WriteLine(client.BilPrisUdenRabatStorebælt());
            }


            Console.ReadLine();

        }
    }
}
