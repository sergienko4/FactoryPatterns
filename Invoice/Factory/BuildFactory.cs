using Invoce.Builds;
using Invoce.Enum;
using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Invoce.Factory
{
    public class FactoryBuild
    {
        private static FactoryBuild _instanceFactory;

        public static FactoryBuild InstanceFactory
        {
            get { return _instanceFactory ?? (_instanceFactory = new FactoryBuild()); }
        }
        private FactoryBuild()
        {

        }
        /// <summary>
        /// create one instance for the application
        /// </summary>
        /// <summary>
        /// Create a build dependence on type 
        /// </summary>
        /// <param name="type">type of the build</param>
        /// <param name="amount">will be inside the build </param>
        /// <returns></returns>
        public Build CreateBuild(BuildType type, long amount)
        {
            Build build = null;
            switch (type)
            {
                case BuildType.AC:
                    return new Electrical(type,amount);
                    break;
                case BuildType.Gaz:
                    return new Gaz(type, amount);
                    
                case BuildType.Water:
                    return  new Water(type, amount);
                default:
                    return build;
            }
        }

    }
}
