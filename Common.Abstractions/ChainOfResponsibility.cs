namespace Ksh.Common.Abstractions;

public interface IHandler<T>
{
    IHandler<T> SetNextHandler(IHandler<T> handler);
    T Handle(T obj);
}

public interface IAsyncHandler<T>
{
    IHandler<T> SetNextHandler(IHandler<T> handler);
    Task<T> HandleAsync(T obj, CancellationToken cancellationToken);
}