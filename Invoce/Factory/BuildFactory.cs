using Invoce.Builds;
using Invoce.Enum;
using System;

namespace Invoce.Factory
{
    public class FactoryBuld
    {
        public static FactoryBuld InstanceFactory;
        private FactoryBuld()
        {

        }
        /// <summary>
        /// create one instance for the application
        /// </summary>
        static FactoryBuld()
        {
            InstanceFactory = new FactoryBuld();
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
                case BuildType.Watter:
                    build = new Watter();
                    break;
            }
            if (build != null)
            {
                build.Amount = amount;
                build.date = DateTime.Now;
                return build;
            }
            return null;
        }

    }
}
