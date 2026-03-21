using System.IO.MemoryMappedFiles;

namespace Proton.Repositories;

public interface IBaseRepository<in TKey, TModel>
{
    Task<TModel> GetAsync(TKey id);
    Task<TModel> CreateAsync(TModel model);
}

public class BaseRepository<TKey, TModel, TEntity> 
    : IBaseRepository<TKey, TModel>
{
    public virtual Task<TModel> GetAsync(TKey id)
    {
        // var entity = Connection.QueryFirst<TEntity>(id);
        // return Mapper.Map<TModel>(entity);
        throw new NotImplementedException();
    }

    public virtual Task<TModel> CreateAsync(TModel model)
    {
        throw new NotImplementedException();
    }
}