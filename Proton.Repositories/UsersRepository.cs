using Proton.Common.Mapper;
using Proton.Models;
using Proton.Repositories.DbContexts;
using Proton.Repositories.Entities;

namespace Proton.Repositories;

public interface  IUsersRepository : IBaseRepository<long, UserModel> {}

public class UsersRepository(
    SchoolDbContext context,
    IMapper<UserModel, UserEntity> mapper) : 
    BaseRepository<long, UserModel, UserEntity>, 
    IUsersRepository
{
    public override async Task<UserModel> GetAsync(long id)
    {
        var entity = await context.Users.FindAsync(id);

        return entity is null 
            ? throw new KeyNotFoundException() 
            : mapper.Map(entity);
    }
}