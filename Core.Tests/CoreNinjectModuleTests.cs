using IoCContainers.Core.Registration;
using Ninject;
using Xunit;

namespace IoCContainers.Core.Tests
{
    public sealed class CoreNinjectModuleTests : AbstractRegistrationTests
    {
        [Fact]
        public override void CanResolveIProductRepository()
        {
            using (var kernel = new StandardKernel(new CoreNinjectModule()))
            {
                var repo = kernel.Get<IProductRepository>();

                Assert.NotNull(repo);
            }
        }

        [Fact]
        public  override void CanResolveOpenGenericType()
        {
            using (var kernel = new StandardKernel(new CoreNinjectModule()))
            {
                var repo = kernel.Get<IRepository<Product>>();

                Assert.NotNull(repo);
            }
        }
    }
}
