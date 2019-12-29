using Api.Core.Domain.Entities;
using Api.Infrastructure.Data.Entities;
using AutoMapper;

namespace Api.Infrastructure.Data.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<AppUser, UserEntity>().ConstructUsing(u => new UserEntity { Id = u.Id, FirstName = u.FirstName, LastName = u.LastName, UserName = u.UserName, PasswordHash = u.PasswordHash });
            CreateMap<UserEntity, AppUser>().ConstructUsing(au => new AppUser(au.FirstName, au.LastName, au.Email, au.UserName, au.Id, au.PasswordHash));
        }
    }
}
