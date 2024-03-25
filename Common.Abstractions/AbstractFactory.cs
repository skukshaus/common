namespace Ksh.Common.Abstractions;

public interface IAbstractFactory;

public interface IAbstractFactory<in TParam> : IAbstractFactory;