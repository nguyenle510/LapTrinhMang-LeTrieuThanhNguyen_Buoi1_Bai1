using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;


namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            // Lấy IP
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Console.WriteLine("IP Address :" + IP);
            Console.ReadKey();
        }
    }
}
