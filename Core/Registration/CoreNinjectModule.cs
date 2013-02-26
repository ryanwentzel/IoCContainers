using Ninject.Modules;

namespace IoCContainers.Core.Registration
{
    public sealed class CoreNinjectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(x => x.FromThisAssembly().SelectAllClasses().BindAllInterfaces());
        }
    }
}
