using Proton.Models;
using Proton.Repositories;

namespace Proton.Services;

public interface IUsersService : IBaseService<int, UserModel> {}

public class UsersService(IUsersRepository usersRepository) : 
    BaseService<int, UserModel>(usersRepository), IUsersService
{
    
}