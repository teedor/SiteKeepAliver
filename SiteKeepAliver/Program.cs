using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SiteKeepAliver
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadLines("urls.txt");
            foreach (var url in lines)
            {
                Console.WriteLine($"Connecting to {url}");
                var client = new RestClient(url);
                var request = new RestRequest
                {
                    Method = Method.GET
                };

                var response = client.Execute(request);
            }
        }
    }
}
