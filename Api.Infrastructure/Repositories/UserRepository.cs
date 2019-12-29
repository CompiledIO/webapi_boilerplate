using Api.Core.Domain.Entities;
using Api.Core.Dto;
using Api.Core.Dto.Repositories;
using Api.Core.Interfaces.Repositories;
using Api.Infrastructure.Data.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<UserEntity> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<UserEntity> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<CreateUserResponse> Create(AppUser user, string password)
        {
            var appUser = _mapper.Map<UserEntity>(user);
            var identityResult = await _userManager.CreateAsync(appUser, password);
            return new CreateUserResponse(appUser.Id, identityResult.Succeeded, identityResult.Succeeded ? null : identityResult.Errors.Select(e => new Error(e.Code, e.Description)));
        }

        public async Task<AppUser> FindByName(string userName)
        {
            return _mapper.Map<AppUser>(await _userManager.FindByNameAsync(userName));
        }

        public async Task<bool> CheckPassword(AppUser user, string password)
        {
            return await _userManager.CheckPasswordAsync(_mapper.Map<UserEntity>(user), password);
        }
    }
}
