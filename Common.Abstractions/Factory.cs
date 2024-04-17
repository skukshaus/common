namespace Ksh.Common.Abstractions;

public interface IFactory;

public interface IFactory<out TResult> : IFactory
{
    TResult Create();
}

public interface IFactory<out TResult, in TParam> : IFactory
{
    TResult Create(TParam param);
}

public interface IFactory<out TResult, in TParam1, in TParam2> : IFactory
{
    TResult Create(TParam1 param1, TParam2 param2);
}

public interface IFactory<out TResult, in TParam1, in TParam2, in TParam3> : IFactory
{
    TResult Create(TParam1 param1, TParam2 param2, TParam3 param3);
}

public interface IAsyncFactory;

public interface IAsyncFactory<TResult> : IAsyncFactory
{
    Task<TResult> CreateAsync();
}

public interface IAsyncFactory<TResult, in TParam> : IAsyncFactory
{
    Task<TResult> CreateAsync(TParam param, CancellationToken cancellationToken);
}

public interface IAsyncFactory<TResult, in TParam1, in TParam2> : IAsyncFactory
{
    Task<TResult> CreateAsync(TParam1 param1, TParam2 param2, CancellationToken cancellationToken);
}

public interface IAsyncFactory<TResult, in TParam1, in TParam2, in TParam3> : IAsyncFactory
{
    Task<TResult> CreateAsync(TParam1 param1, TParam2 param2, TParam3 param3, CancellationToken cancellationToken);
}