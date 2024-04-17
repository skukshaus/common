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
    Task<IQueryable<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<TEntity> GetByIdAsync(TKey id, CancellationToken cancellationToken);

    Task CreateAsync(TEntity obj, CancellationToken cancellationToken);
    Task UpdateAsync(TEntity obj, CancellationToken cancellationToken);
    Task DeleteAsync(TKey idx, CancellationToken cancellationToken);
}