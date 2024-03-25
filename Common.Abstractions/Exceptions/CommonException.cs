namespace Ksh.Common.Abstractions.Exceptions;

[ExcludeFromCodeCoverage] public class CommonException : Exception
{
    public CommonException()
    {
    }

    public CommonException(string message) : base(message)
    {
    }

    public CommonException(string message, Exception inner) : base(message, inner)
    {
    }
}