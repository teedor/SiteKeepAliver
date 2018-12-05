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
            foreach (var line in lines)
            {
                var client = new RestClient(line);
                var request = new RestRequest();
                request.Method = Method.GET;
                var response = client.Execute(request);
            }
        }
    }
}
