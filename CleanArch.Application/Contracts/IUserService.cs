using CleanArch.Application.DTOs;

namespace CleanArch.Application.Contracts;

public interface IUserService
{
    Task<UserDto?> GetUserByIdAsync(Guid id, CancellationToken ct = default);

    // Можно добавить позже:
    // Task<Guid> CreateUserAsync(string userName, CancellationToken ct = default);
}