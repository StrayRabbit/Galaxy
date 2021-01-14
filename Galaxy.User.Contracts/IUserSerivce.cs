using System.Threading.Tasks;
using Galaxy.User.Contracts.Models.Dtos;
using Volo.Abp.Application.Services;

namespace Galaxy.User.Contracts
{
    public interface IUserSerivce : IApplicationService
    {
        Task<UserDto> GetAsync();
    }
}