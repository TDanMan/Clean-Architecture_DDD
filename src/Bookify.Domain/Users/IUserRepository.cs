namespace Bookify.Domain.Users;
public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken ct = default);
    void AddUser(User user);
}
