namespace Ksh.Common.Abstractions;

public interface IEntity<TKey>
    where TKey : struct, IComparable
{
    public TKey Id { get; init; }
}

public interface IAggregateRoot<TKey>
    where TKey : struct, IComparable
{
    public TKey Id { get; init; }
}