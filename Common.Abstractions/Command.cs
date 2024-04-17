namespace Ksh.Common.Abstractions;

public interface ICommand : IDisposable
{
    void Execute();
    bool CanExecute();
}

public interface ICommand<in TParam> : IDisposable
{
    void Execute(TParam param);
    bool CanExecute();
}

public interface ICommand<in TParam1, in TParam2> : IDisposable
{
    void Execute(TParam1 param1, TParam2 param2);
    bool CanExecute();
}

public interface ICommand<in TParam1, in TParam2, in TParam3> : IDisposable
{
    void Execute(TParam1 param1, TParam2 param2, TParam3 param3);
    bool CanExecute();
}

public interface IAsyncCommand : IAsyncDisposable
{
    Task ExecuteAsync(CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam> : IAsyncDisposable
{
    Task ExecuteAsync(TParam param, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam1, in TParam2> : IAsyncDisposable
{
    Task ExecuteAsync(TParam1 param1, TParam2 param2, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam1, in TParam2, in TParam3> : IAsyncDisposable
{
    Task ExecuteAsync(TParam1 param1, TParam2 param2, TParam3 param3, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}