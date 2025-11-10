using GenericRepository;
using RentACarServer.Domain.Users;
using RentACarServer.Infrastructure.Context;

namespace RentACarServer.Infrastructure.Repositories;

internal sealed class UserRepository(ApplicationDbContext context) : Repository<User, ApplicationDbContext>(context), IUserRepository
{
}