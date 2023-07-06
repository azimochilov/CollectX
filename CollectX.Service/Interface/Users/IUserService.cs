using CollectX.Service.DTOs.Users;

namespace CollectX.Service.Interface.Users;
public interface IUserService
{
    Task<UserResultDto> AddAsync(UserCreationDto dto);
    Task<IEnumerable<UserResultDto>> RetrieveAllAsync();
    Task<bool> RemoveAsync(long id);
    Task<UserResultDto> RetrieveByIdAsync(long id);
    Task<UserResultDto> ModifyAsync(long id, UserUpdateDto dto);
    Task<UserResultDto> ChangePasswordAsync(UserChangePasswordDto dto);
}
