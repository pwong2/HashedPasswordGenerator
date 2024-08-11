using BCrypt.Net;


class Program
{
    static void Main()
    {
        string password = "AdminPassword123"; // Replace with your desired password
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        System.Console.WriteLine("Hashed Password: " + hashedPassword);
    }
}