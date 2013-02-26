
using IoCContainers.Core.Impl;
using UnityConfiguration;

namespace IoCContainers.Core.Registration
{
    public class CoreUnityRegistry : UnityRegistry
    {
        public CoreUnityRegistry()
        {
            //container.RegisterType<IProductRepository, ProductRepository>();

            //// Register open generic type
            //container.RegisterType(typeof(IRepository<>), typeof(Repository<>));

            Scan(scan => 
            {
                scan.AssemblyContaining<IProductRepository>();
                scan.WithNamingConvention();
            });

            Register(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
