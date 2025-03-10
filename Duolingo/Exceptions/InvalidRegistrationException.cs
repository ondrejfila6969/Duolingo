namespace Duolingo;

public class InvalidRegistrationException: Exception
{
    public InvalidRegistrationException(int registrationDoesNotExist) 
        : base($"Registration {registrationDoesNotExist} does not exist.")
    {
    }
}