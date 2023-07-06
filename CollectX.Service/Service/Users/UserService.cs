using CollectX.Service.DTOs.Users;
using CollectX.Service.Interface.Users;

namespace CollectX.Service.Service.Users;
public class UserService : IUserService
{
    public Task<UserResultDto> AddAsync(UserCreationDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> ChangePasswordAsync(UserChangePasswordDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> ModifyAsync(long id, UserUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserResultDto>> RetrieveAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserResultDto> RetrieveByIdAsync(long id)
    {
        throw new NotImplementedException();
    }
}
