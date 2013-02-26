using IoCContainers.Core.Impl;
using StructureMap.Configuration.DSL;

namespace IoCContainers.Core.Registration
{
    public sealed class CoreRegistry : Registry
    {
        public CoreRegistry()
        {
            // Register open generic type
            For(typeof(IRepository<>)).Use(typeof(Repository<>));

            Scan(scan => 
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });
        }
    }
}
