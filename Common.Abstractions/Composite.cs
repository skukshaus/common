namespace Ksh.Common.Abstractions;

public interface IComposite;

public interface IComposite<in T>
{
    void Traverse();

    void AddElement(T obj);

    void RemoveElement(T obj);

    void ClearElements();
}

public interface IAsyncComposite;

public interface IAsyncComposite<in T> : IAsyncComposite
{
    Task TraverseAsync(CancellationToken cancellationToken);

    Task AddElementAsync(T obj, CancellationToken cancellationToken);

    Task RemoveElementAsync(T obj, CancellationToken cancellationToken);

    Task ClearElementsAsync(CancellationToken cancellationToken);
}