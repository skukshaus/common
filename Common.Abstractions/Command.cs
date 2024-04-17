namespace Ksh.Common.Abstractions;

public interface ICommand
{
    void Execute();
    bool CanExecute();
}

public interface ICommand<in TParam>
{
    void Execute(TParam param);
    bool CanExecute();
}

public interface ICommand<in TParam1, in TParam2>
{
    void Execute(TParam1 param1, TParam2 param2);
    bool CanExecute();
}

public interface ICommand<in TParam1, in TParam2, in TParam3>
{
    void Execute(TParam1 param1, TParam2 param2, TParam3 param3);
    bool CanExecute();
}

public interface IAsyncCommand
{
    Task ExecuteAsync(CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam>
{
    Task ExecuteAsync(TParam param, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam1, in TParam2>
{
    Task ExecuteAsync(TParam1 param1, TParam2 param2, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}

public interface IAsyncCommand<in TParam1, in TParam2, in TParam3>
{
    Task ExecuteAsync(TParam1 param1, TParam2 param2, TParam3 param3, CancellationToken cancellationToken);
    Task<bool> CanExecuteAsync(CancellationToken cancellationToken);
}