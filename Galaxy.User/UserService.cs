using System.Threading.Tasks;
using Galaxy.User.Contracts;
using Galaxy.User.Contracts.Models.Dtos;
using Volo.Abp.Application.Services;

namespace Galaxy.User
{
    public class UserService : ApplicationService, IUserSerivce
    {
        public Task<UserDto> GetAsync()
        {
            return Task.FromResult(new UserDto()
            {
                Id = "1",
                Name = "name",
            });
        }
    }
}