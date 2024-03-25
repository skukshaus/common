namespace Ksh.Common.Abstractions;

public interface IShallowCopy<out TResult>
{
    TResult ShallowCopy();
}
public interface IDeepCopy<out TResult>
{
    TResult DeepCopy();
}

public interface IAsyncShallowCopy<TResult>
{
    Task<TResult> ShallowCopyAsync();
}
public interface IAsyncDeepCopy<TResult>
{
    Task<TResult> DeepCopyAsync();
}