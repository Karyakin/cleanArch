namespace CleanArch.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string? UserName { get; private set; }

    // Конструктор для создания (можно добавить фабричный метод позже)
    public User(Guid id, string? userName)
    {
        if (id == Guid.Empty) throw new ArgumentException("Id cannot be empty", nameof(id));
        Id = id;
        UserName = userName;
    }
}