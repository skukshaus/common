namespace Ksh.Common.Abstractions;

public interface IComposite : IDisposable;

public interface IComposite<in T> : IComposite
{
    void Traverse();

    void AddElement(T obj);

    void RemoveElement(T obj);

    void ClearElements();
}

public interface IAsyncComposite : IAsyncDisposable;

public interface IAsyncComposite<in T> : IAsyncCommand
{
    Task TraverseAsync();

    Task AddElementAsync(T obj);

    Task RemoveElementAsync(T obj);

    Task ClearElementsAsync();
}