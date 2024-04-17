namespace Ksh.Common.Abstractions;

public interface IUnitOfWork<TKey>
    where TKey : struct, IComparable
{
    IRepository<TEntity, TKey> GetRepository<TEntity>()
        where TEntity : class, IEntity<TKey>;

    void Commit();
    void Rollback();
}

public interface IAsyncUnitOfWork<TKey>
    where TKey : struct, IComparable
{
    Task<IAsyncRepository<TEntity, TKey>> GetRepositoryAsync<TEntity>(CancellationToken cancellationToken)
        where TEntity : class, IEntity<TKey>;

    Task CommitAsync(CancellationToken cancellationToken);
    Task RollbackAsync(CancellationToken cancellationToken);
}