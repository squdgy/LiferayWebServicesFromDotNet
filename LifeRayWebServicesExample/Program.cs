using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LifeRayWebServicesExample.LiferayUserService;

namespace LifeRayWebServicesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new UserServiceSoapClient();
            client.ClientCredentials.UserName.UserName = "2";
            client.ClientCredentials.UserName.Password = "test";
            var user = client.getUserByScreenName(1, "joebloggs");
            Console.WriteLine(user.greeting);
            Console.ReadLine();
        }
    }
}
