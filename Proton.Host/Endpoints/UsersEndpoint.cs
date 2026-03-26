using Proton.Host.Services;
using Proton.Models;
using Proton.Services;

namespace Proton.Host.Endpoints;

public interface IUsersEndpoint
{
    Task<ICollection<UserModel>> GetAllAsync(string? where);
    Task<UserModel> GetAsync(long id);
    Task<UserModel> CreateAsync(UserModel model);
    Task<UserModel> UpdateAsync(long id, UserModel model);
    Task DeleteAsync(long id);
}

public class UsersEndpoint(
    AuthorizationContextService context,
    IUsersService usersService) : IUsersEndpoint
{
    public Task<ICollection<UserModel>> GetAllAsync(string? where)
    {
        return usersService.GetAllAsync(where);
    }

    public Task<UserModel> GetAsync(long id) => usersService.GetAsync(id);
    public Task<UserModel> CreateAsync(UserModel model) => usersService.CreateAsync(model);
    public Task<UserModel> UpdateAsync(long id, UserModel model) => usersService.UpdateAsync(id, model);
    public Task DeleteAsync(long id) => usersService.DeleteAsync(id);
}