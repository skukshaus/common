namespace Ksh.Common.Abstractions;



public interface IRepository<TEntity, in TKey>
    where TEntity : class, IEntity<TKey>
    where TKey : struct, IComparable
{
    IQueryable<TEntity> GetAll();
    TEntity GetById(TKey id);

    void Create(TEntity obj);
    void Update(TEntity obj);
    void Delete(TKey idx);
}

public interface IAsyncRepository<TEntity, in TKey>
    where TEntity : class, IEntity<TKey>
    where TKey : struct, IComparable
{
    Task<IQueryable<TEntity>> GetAllAsync();
    Task<TEntity> GetByIdAsync(TKey id);

    Task CreateAsync(TEntity obj);
    Task UpdateAsync(TEntity obj);
    Task DeleteAsync(TKey idx);
}