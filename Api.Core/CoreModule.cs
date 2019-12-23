using Autofac;
using System;

namespace Api.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            //builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();
        }
    }
}
