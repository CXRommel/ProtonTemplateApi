using Proton.Models;
using Proton.Repositories.Entities;

namespace Proton.Repositories;

public interface  IUsersRepository : IBaseRepository<int, UserModel> {}

public class UsersRepository : 
    BaseRepository<int, UserModel, UserEntity>, 
    IUsersRepository
{
    public override Task<UserModel> GetAsync(int id)
    {
        return Task.FromResult(new UserModel()
        {
            Id = id,
            FirstName = "Jose",
            LastName = "Perez"
        });
    }
}