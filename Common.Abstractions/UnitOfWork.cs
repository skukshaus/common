namespace Ksh.Common.Abstractions;

public interface IUnitOfWork<TKey> : IDisposable 
    where TKey : struct, IComparable 
{
    IRepository<TEntity, TKey> GetRepository<TEntity>() 
        where TEntity : class, IEntity<TKey>;

    void Commit();
    void Rollback();
}


public interface IAsyncUnitOfWork<TKey> : IAsyncDisposable 
    where TKey : struct, IComparable 
{
    Task<IAsyncRepository<TEntity, TKey>> GetRepositoryAsync<TEntity>(CancellationToken cancellationToken) 
        where TEntity : class, IEntity<TKey>;

    Task Commit(CancellationToken cancellationToken);
    Task Rollback(CancellationToken cancellationToken);
}