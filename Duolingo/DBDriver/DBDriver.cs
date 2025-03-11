using Duolingo.Languages;
using Duolingo.Registration;

namespace Duolingo;
using MySqlConnector;

public class DBDriver
{
    private static string ServerDomain = "localhost";
    private static string Username = "root";
    private static string Password = "";
    private static string Database = "duolingo";
    private static string connectionString =>
        $"Server={ServerDomain};Database={Database};User={Username};Password={Password};Port=3306;";

    public Exception? ThrownException;
    
    public DBDriver(string password)
    {
        Password = password;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public List<User> GetUsers()
    {
        List<User> users = new List<User>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM users";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                var user = new User();
                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.DateCreated = reader.GetDateTime(2);
                user.DateModified = reader.GetDateTime(3);
                users.Add(user);
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        Console.WriteLine(users);
        return users;
    }

    public void InsertUser(User user)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           "INSERT INTO users VALUES (NULL, @username, current_timestamp(), current_timestamp())",
                           connection))
                {
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
   
    public void DeteteUser(int id)
    {
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "DELETE FROM users WHERE id = @id;";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            int effectedRows = command.ExecuteNonQuery();
            if (effectedRows == 0)
            {
                ThrownException = new InvalidUserException(id);
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }
    }
    
    public List<LanguageTemplate> GetLanguages()
    {
        List<LanguageTemplate> languages = new List<LanguageTemplate>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM languages";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                var language = new LanguageTemplate();
                language.Id = reader.GetInt32(0);
                language.Name = reader.GetString(1);
                language.DateCreated = reader.GetDateTime(2);
                language.DateModified = reader.GetDateTime(3);
                languages.Add(language);
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        return languages;
    }

    public void InsertLanguage(LanguageTemplate language)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           "INSERT INTO languages VALUES (NULL, @languageName, current_timestamp(), current_timestamp())",
                           connection))
                {
                    command.Parameters.AddWithValue("@languageName", language.Name);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
   
    public void DeleteLanguage(int ID)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           " DELETE FROM languages WHERE id=@id",
                           connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        ThrownException = new InvalidLanguageException(ID);
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
    
    public List<RegistrationTemplate> GetRegistrations()
    {
        List<RegistrationTemplate> registrations = new List<RegistrationTemplate>();
        MySqlConnection connection = GetConnection();
        try
        {
            connection.Open();
            string query = "SELECT * FROM registrations";
            MySqlCommand command = new MySqlCommand(query, connection);
            // execute reader
            var reader = command.ExecuteReader();
            // while reader.next
            while (reader.Read())
            {
                var registration = new RegistrationTemplate();
                registration.Id = reader.GetInt32(0);
                registration.UserId = reader.GetInt32(1);
                registration.LanguageId = reader.GetInt32(2);
                registrations.Add(registration);
            }
        }
        catch (MySqlException ex)
        {
            ThrownException = ex;
        }

        // return list
        return registrations;
    }

    public void InsertRegistration(RegistrationTemplate registration)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           "INSERT INTO registrations VALUES (NULL, @userId, @languageId)",
                           connection))
                {
                    command.Parameters.AddWithValue("@userId", registration.UserId);
                    command.Parameters.AddWithValue("@languageId", registration.LanguageId);
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
   
    public void DeleteRegistration(int ID)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                using (var command = new MySqlCommand(
                           " DELETE FROM registrations WHERE id=@id",
                           connection))
                {
                    command.Parameters.AddWithValue("@id", ID);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        ThrownException = new InvalidRegistrationException(ID);
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                ThrownException = ex;
            }
        }
    }
    
    public bool RegistrationAlreadyExists(int userId, int languageId)
    {
        using (MySqlConnection connection = GetConnection())
        {
            connection.Open();

            string command = "SELECT COUNT(*) FROM registrations WHERE user_id = @userId AND language_id = @languageId";
            MySqlCommand cmd = new MySqlCommand(command, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@languageId", languageId);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }
    }
    
}