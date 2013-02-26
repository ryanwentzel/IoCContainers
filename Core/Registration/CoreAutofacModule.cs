using Autofac;
using IoCContainers.Core.Impl;

namespace IoCContainers.Core.Registration
{
    public sealed class CoreAutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>));
        }
    }
}
