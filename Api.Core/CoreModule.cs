using Api.Core.Interfaces.Services;
using Api.Core.Services;
using Autofac;

namespace Api.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegisterService>().As<IRegisterService>().InstancePerLifetimeScope();
            builder.RegisterType<LoginService>().As<ILoginService>().InstancePerLifetimeScope();
        }
    }
}
