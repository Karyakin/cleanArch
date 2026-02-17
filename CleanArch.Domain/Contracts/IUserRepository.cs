using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Contracts;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default);

    Task AddAsync(User user, CancellationToken ct = default);

    // Можно расширить позже: UpdateAsync, DeleteAsync, ExistsAsync и т.д.
}