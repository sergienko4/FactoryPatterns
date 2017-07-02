using Invoce.Enum;
using Invoce.Factory;
using System;
using System.Collections.Generic;

namespace Invoce
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var list = new List<Client>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new Client($"Test-{i})"));
            }

            string input = string.Empty;
            while (input != "-1")
            {
                Console.WriteLine("enter build type");
                input = Console.ReadLine();
                if (input == "-1") continue;
                var id = Convert.ToInt16(input);
                var buildType = (BuildType)id;
                Console.WriteLine("enter amount");

                input = Console.ReadLine();
                if (input == "-1") continue;
                var amount = Convert.ToInt64(input);
                var clientIndex = rnd.Next(0, 5);
                var build = FactoryBuild.CreateBuild(buildType, amount);
                if (build != null)
                    list[clientIndex].AddBuild(build);
                else
                {
                    Console.WriteLine("---- build type is empty or incorrect ----");
                }
            }
            foreach (Client client in list)
            {
                client.Print();
            }
            Console.ReadKey();


        }
    }
}
