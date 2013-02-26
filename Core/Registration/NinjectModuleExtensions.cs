using System;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Conventions.Syntax;
using Ninject.Modules;

namespace IoCContainers.Core.Registration
{
    public static class NinjectModuleExtensions
    {
        public static void Bind(this INinjectModule module, Action<IFromSyntax> configure)
        {
            module.Kernel.Bind(configure);
        }
    }
}
