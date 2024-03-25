namespace Ksh.Common.Abstractions;

public interface IHandler<T>
{
    IHandler<T> SetNextHandler(IHandler<T> handler);
    T Handle(T obj);
}