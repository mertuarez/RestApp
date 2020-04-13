using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api;
using Microsoft.Rest;
namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new ApiClient(new BasicAuthenticationCredentials());

            bool? x = svc.User.HasUser("asd");

        }
    }
}
