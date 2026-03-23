using Proton.Models;
using Proton.Repositories;

namespace Proton.Services;

public interface IUsersService : IBaseService<long, UserModel> {}

public class UsersService(IUsersRepository usersRepository) : 
    BaseService<long, UserModel>(usersRepository), IUsersService
{
    
}