using Microsoft.Practices.Unity;
using UnityConfiguration;
using Xunit;

namespace IoCContainers.Core.Tests
{
    public sealed class CoreUnityRegistryTests : AbstractRegistrationTests
    {
        [Fact]
        public override void CanResolveIProductRepository()
        {
            using (var container = new UnityContainer())
            {
                container.Configure(x => x.Scan(scan => 
                {
                    scan.Assembly("IoCContainers.Core.dll");
                    scan.ForRegistries();
                }));

                var repo = container.Resolve<IProductRepository>();

                Assert.NotNull(repo);
            }
        }

        [Fact]
        public override void CanResolveOpenGenericType()
        {
            using (var container = new UnityContainer())
            {
                container.Configure(x => x.Scan(scan =>
                {
                    scan.Assembly("IoCContainers.Core.dll");
                    scan.ForRegistries();
                }));

                var repo = container.Resolve<IRepository<Product>>();

                Assert.NotNull(repo);
            }
        }
    }
}
