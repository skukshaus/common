namespace Ksh.Common.Abstractions;

public interface IBuilder<out T>
{
    T Build();

    void Reset();
}
public interface IAsyncBuilder<T>
{
    Task<T> BuildAsync(CancellationToken cancellationToken);

    Task ResetAsync(CancellationToken cancellationToken);
}