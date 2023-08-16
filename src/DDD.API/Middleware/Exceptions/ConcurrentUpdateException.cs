namespace DDD.API.Middleware.Exceptions;

public class ConcurrentUpdateException : Exception
{
    public ConcurrentUpdateException() { }

    public ConcurrentUpdateException(string message) : base(message) { }

    public ConcurrentUpdateException(string message, Exception innerException) : base(message, innerException) { }
}