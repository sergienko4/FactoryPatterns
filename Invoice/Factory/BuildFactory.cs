using Invoce.Builds;
using Invoce.Enum;
using System;

namespace Invoce.Factory
{
    public class FactoryBuild
    {
        public static FactoryBuild InstanceFactory;
        private FactoryBuild()
        {

        }
        /// <summary>
        /// create one instance for the application
        /// </summary>
        static FactoryBuild()
        {
            InstanceFactory = new FactoryBuild();
        }
        /// <summary>
        /// Create a build dependence on type 
        /// </summary>
        /// <param name="type">type of the build</param>
        /// <param name="amount">will be inside the build </param>
        /// <returns></returns>
        public static Build CreateBuild(BuildType type, long amount)
        {
            Build build = null;
            switch (type)
            {
                case BuildType.AC:
                    build = new Electrical();
                    break;
                case BuildType.Gaz:
                    build = new Gaz();
                    break;
                case BuildType.Water:
                    build = new Water();
                    break;
            }
            if (build != null)
            {
                build.Amount = amount;
                build.Date = DateTime.Now;
                return build;
            }
            return null;
        }

    }
}
