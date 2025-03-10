namespace Duolingo;

public class InvalidUserException : Exception
{
    public InvalidUserException(int userDoesNotExist) 
        : base($"User {userDoesNotExist} does not exist.")
    {
    }
}