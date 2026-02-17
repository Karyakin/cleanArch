using CleanArch.Domain.Contracts;
using CleanArch.Domain.Entities;

namespace CleanArch.Infrastructure.Services;

public class UserRepository : IUserRepository
{
    // Пока заглушка (в реальном проекте — EF Core, Dapper, Cosmos и т.д.)

    public Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default)
    {
        // Симуляция: всегда возвращаем пользователя с запрошенным Id
        var user = new User(id, $"User-{id.ToString()[..8]}");
        return Task.FromResult<User?>(user);
    }

    public Task AddAsync(User user, CancellationToken ct = default)
    {
        // Симуляция сохранения
        Console.WriteLine($"[MOCK] User saved → Id: {user.Id}, Name: {user.UserName}");
        return Task.CompletedTask;
    }
}