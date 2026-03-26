using Proton.Repositories;

namespace Proton.Services;

public interface IBaseService<in TKey, TModel>
{
    Task<ICollection<TModel>> GetAllAsync(string? where);
    Task<TModel> GetAsync(TKey id);
    Task<TModel> CreateAsync(TModel model);
    Task<TModel> UpdateAsync(TKey id, TModel model);
    Task DeleteAsync(TKey id);
}

public class BaseService<TKey, TModel>(IBaseRepository<TKey, TModel> repository) : 
    IBaseService<TKey, TModel>
{
    public virtual Task<ICollection<TModel>> GetAllAsync(string? where) => repository.GetAllAsync(where);
    public virtual Task<TModel> GetAsync(TKey id) => repository.GetAsync(id);
    public virtual Task<TModel> CreateAsync(TModel model) => repository.CreateAsync(model);
    public virtual Task<TModel> UpdateAsync(TKey id, TModel model) => repository.UpdateAsync(id, model);
    public virtual Task DeleteAsync(TKey id) => repository.DeleteAsync(id);
}