namespace Ksh.Common.Abstractions;

public interface IMemento<T>
{
    T GetState();
    void SetState(T state);
}

public interface ICaretaker<T, in TIndex>
{
    void AddMemento(IMemento<T> memento);
    IMemento<T> GetMemento(TIndex idx);
}

public interface ICaretaker<T> : ICaretaker<T, int>
{
}

public interface IOriginator<T>
{
    IMemento<T> CreateMemento();
    void Restore(IMemento<T> memento);
}