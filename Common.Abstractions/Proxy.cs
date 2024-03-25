namespace Ksh.Common.Abstractions;

public interface IProxy;

public interface IProxy<TSubject> where TSubject : IProxySubject;

public interface IProxySubject;