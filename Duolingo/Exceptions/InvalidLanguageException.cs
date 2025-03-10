namespace Duolingo;

public class InvalidLanguageException : Exception
{
    public InvalidLanguageException(int languageDoesNotExist) 
        : base($"Language {languageDoesNotExist} does not exist.")
    {
    }
}