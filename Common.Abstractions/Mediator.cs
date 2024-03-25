namespace Ksh.Common.Abstractions;

public interface IMediator<T>
{
    void Notify(IMediatedSubject<T> subject, T obj);
}

public interface IMediatedSubject<T>
{
    void SetMediator(IMediator<T> mediator);
}