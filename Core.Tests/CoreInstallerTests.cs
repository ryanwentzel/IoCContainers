using Castle.Windsor;
using IoCContainers.Core.Registration;
using Xunit;

namespace IoCContainers.Core.Tests
{
    public sealed class CoreInstallerTests : AbstractRegistrationTests
    {
        [Fact]
        public override void CanResolveIProductRepository()
        {
            using (var container = new WindsorContainer())
            {
                container.Install(new CoreInstaller());
                var repo = container.Resolve<IProductRepository>();

                Assert.NotNull(repo);
            }
        }

        [Fact]
        public override void CanResolveOpenGenericType()
        {
            using (var container = new WindsorContainer())
            {
                container.Install(new CoreInstaller());

                var repo = container.Resolve<IRepository<Product>>();

                Assert.NotNull(repo);
            }
        }
    }
}
