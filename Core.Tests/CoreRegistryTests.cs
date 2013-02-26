using IoCContainers.Core.Registration;
using StructureMap;
using Xunit;

namespace IoCContainers.Core.Tests
{
    public sealed class CoreRegistryTests : AbstractRegistrationTests
    {
        [Fact]
        public override void CanResolveIProductRepository()
        {
            using (var container = new Container(new CoreRegistry()))
            {
                var repo = container.GetInstance<IProductRepository>();

                Assert.NotNull(repo);
            }
        }

        [Fact]
        public override void CanResolveOpenGenericType()
        {
            using (var container = new Container(new CoreRegistry()))
            {
                var repo = container.GetInstance<IRepository<Product>>();

                Assert.NotNull(repo);
            }
        }
    }
}
