namespace Lauerp_Domain.Exceptions;

public class EmptyValueException : Exception
{
    public EmptyValueException(string? message) : base(message)
    {

    }
}
