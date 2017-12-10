using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.SelfHost;

namespace API
{
    public class Program
    {
        static void Main(string[] args)
        {

            var config = new HttpSelfHostConfiguration("http://localhost:50132");

            var server = new HttpSelfHostServer(config);
            var task = server.OpenAsync();
            task.Wait();

            Console.WriteLine("Web API Server has started at http://localhost:50132");
            Console.ReadLine();
        }
    }
}