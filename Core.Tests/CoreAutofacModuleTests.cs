using Autofac;
using IoCContainers.Core.Registration;
using Xunit;

namespace IoCContainers.Core.Tests
{
    public sealed class CoreAutofacModuleTests : AbstractRegistrationTests
    {
        [Fact]
        public override void CanResolveIProductRepository()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new CoreAutofacModule());
            using (var container = builder.Build())
            {
                var repo = container.Resolve<IProductRepository>();

                Assert.NotNull(repo);
            } 
        }

        [Fact]
        public override void CanResolveOpenGenericType()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new CoreAutofacModule());
            using (var container = builder.Build())
            {
                var repo = container.Resolve<IRepository<Product>>();

                Assert.NotNull(repo);
            }
        }
    }
}
