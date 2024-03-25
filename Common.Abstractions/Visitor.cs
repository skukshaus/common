namespace Ksh.Common.Abstractions;

public interface IVisitor<T>
{
    T Visit(T obj);
}

public interface IVisitorAcceptor<T>
{
    T Accept(IVisitor<T> accept);
}

public interface IAsyncVisitor<T>
{
    Task<T> VisitAsync(T obj);
}

public interface IAsyncVisitorAcceptor<T>
{
    Task<T> AcceptAsync(IAsyncVisitor<T> accept);
}