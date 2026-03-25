using Proton.Common.Mapper;
using Proton.Models;
using Proton.Repositories.DbContexts;
using Proton.Repositories.Entities;

namespace Proton.Repositories;

public interface  IUsersRepository : IBaseRepository<long, UserModel> {}

public class UsersRepository(
    SchoolDbContext context,
    IMapper<UserModel, UserEntity> mapper) : 
    BaseRepository<long, UserModel, UserEntity>(context, mapper), 
    IUsersRepository
{
    // public override async Task<UserModel> GetAsync(long id)
    // {
    //     var entity = await context.Users.FindAsync(id);
    //
    //     return entity is null 
    //         ? throw new KeyNotFoundException() 
    //         : mapper.Map(entity);
    // }
    //
    //
    // public override async Task<UserModel> CreateAsync(UserModel model)
    // {
    //     var entity = mapper.Map(model);
    //     
    //     var item = await context.Users.AddAsync(entity);
    //     await context.SaveChangesAsync();
    //
    //     return mapper.Map(item.Entity);
    // }
}