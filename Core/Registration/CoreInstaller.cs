using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using IoCContainers.Core.Impl;

namespace IoCContainers.Core.Registration
{
    public sealed class CoreInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // Register open generic type
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)));

            container.Register(AllTypes.FromThisAssembly().Pick().WithServiceDefaultInterfaces());
        }
    }
}
