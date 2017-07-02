using Invoce.Interface;
using System.Collections.Generic;

namespace Invoce
{
    public class Client : IPrint
    {
        public string Name { get; set; }
        private List<Build> Builds;

        public Client(string name)
        {
            this.Name = name;
            this.Builds = new List<Build>();
        }

        public void AddBuild(Build build)
        {
            Builds.Add(build);
        }
        public void Print()
        {

            foreach (Build build in this.Builds)
            {
                build.Print();
            }
        }
    }
}
