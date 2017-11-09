using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpCalcServer
{
    class Program
    {
        static void Main(string[] args)
        {
              HttpServer server = new HttpServer("http://localhost:8888/");
           // HttpServer server = new HttpServer("http://192.168.0.118:9050/");
            server.Start();
        }
    }
}
