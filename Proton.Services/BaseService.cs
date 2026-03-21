using Proton.Repositories;

namespace Proton.Services;

public interface IBaseService<in TKey, TModel>
{
    Task<TModel> GetAsync(TKey id);
    Task<TModel> CreateAsync(TModel model);
}

public class BaseService<TKey, TModel>(IBaseRepository<TKey, TModel> repository) : 
    IBaseService<TKey, TModel>
{
    public Task<TModel> GetAsync(TKey id) => repository.GetAsync(id);
    public Task<TModel> CreateAsync(TModel model) => repository.CreateAsync(model);
}