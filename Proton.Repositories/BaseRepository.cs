using System.IO.MemoryMappedFiles;
using Microsoft.EntityFrameworkCore;
using Proton.Common.Mapper;
using Proton.Repositories.Pql;

namespace Proton.Repositories;

public interface IBaseRepository<in TKey, TModel>
{
    Task<ICollection<TModel>> GetAllAsync(string? where);
    Task<TModel> GetAsync(TKey id);
    Task<TModel> CreateAsync(TModel model);
    Task<TModel> UpdateAsync(TKey id, TModel model);
    Task DeleteAsync(TKey id);
}

public class BaseRepository<TKey, TModel, TEntity> (DbContext context, IMapper<TModel, TEntity> mapper)
    : IBaseRepository<TKey, TModel> 
    where TEntity : class
{
    public virtual async Task<ICollection<TModel>> GetAllAsync(string? where)
    {
        if (where is null)
        {
            return context.Set<TEntity>()
                .Select(mapper.Map)
                .ToList();
        }
        
        var entities = await context.Set<TEntity>()
            .Where(PqlParser.Parse<TEntity>(where))
            .ToListAsync();
        
        return entities.Select(mapper.Map).ToList();
    }

    public virtual async Task<TModel> GetAsync(TKey id)
    {
        var entity = await context.Set<TEntity>().FindAsync(id);
        
        return entity is null 
            ? throw new KeyNotFoundException() 
            : mapper.Map(entity);
    }

    public virtual async Task<TModel> CreateAsync(TModel model)
    {
        var entity = mapper.Map(model);
        
        var item = await context.Set<TEntity>().AddAsync(entity);
        await context.SaveChangesAsync();

        return mapper.Map(item.Entity);
    }

    public virtual async Task<TModel> UpdateAsync(TKey id, TModel model)
    {
        var record = context.Set<TEntity>().Update(mapper.Map(model));
        await context.SaveChangesAsync();

        return mapper.Map(record.Entity);
    }

    public async Task DeleteAsync(TKey id)
    {
        var record = await context.Set<TEntity>().FindAsync(id);
        context.Set<TEntity>().Remove(record);
        await context.SaveChangesAsync();
    }
}