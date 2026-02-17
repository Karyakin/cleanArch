using CleanArch.Application.Contracts;
using CleanArch.Application.DTOs;
using CleanArch.Domain.Contracts;

namespace CleanArch.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDto?> GetUserByIdAsync(Guid id, CancellationToken ct = default)
    {
        var user = await _userRepository.GetByIdAsync(id, ct);

        if (user is null)
        {
            return null;
        }

        return new UserDto(user.Id, user.UserName);
    }

    // Пример расширения
    /*
    public async Task<Guid> CreateUserAsync(string userName, CancellationToken ct = default)
    {
        var user = new User(Guid.NewGuid(), userName);
        await _userRepository.AddAsync(user, ct);
        return user.Id;
    }
    */
}