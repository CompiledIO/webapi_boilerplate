using Api.Core.Interfaces.Repositories;
using Api.Core.Interfaces.Services;
using Api.Infrastructure.Auth;
using Api.Infrastructure.Repositories;
using Autofac;

namespace Api.Infrastructure
{
    public class InfrastructureModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();
            builder.RegisterType<JwtFactory>().As<IJwtFactory>().SingleInstance();
        }
    }
}
