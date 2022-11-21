internal class Program
{
    private static void Main(string[] args)
    {
        LoginDataServices db = new LoginDataServices();


        string login = new string('t', 40);
        string password = "12345678";

        Console.WriteLine($"\nLogin: {login}; password: {password}");
        UnitTest.LoginTest(login, password);

        login = "Mojahed";
        password = null;

        Console.WriteLine($"\nLogin: {login}; password: {password}");
        UnitTest.LoginTest(login, password);

        login = "Mojahed";
        password = "12345678";

        Console.WriteLine($"\nLogin: {login}; password: {password}");
        UnitTest.LoginTest(login, password);
    }
}