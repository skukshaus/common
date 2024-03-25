namespace Ksh.Common.Abstractions;

public interface IBuilder<out T> : IDisposable
{
    T Build();

    void Reset();
}
public interface IAsyncBuilder<T> : IAsyncDisposable
{
    Task<T> BuildAsync();

    Task ResetAsync();
}