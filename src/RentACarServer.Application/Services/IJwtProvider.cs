using RentACarServer.Domain.Users;

namespace RentACarServer.Application.Services;

public interface IJwtProvider
{
    Task<string> CreateTokenAsync(User user, CancellationToken cancellationToken = default);
}