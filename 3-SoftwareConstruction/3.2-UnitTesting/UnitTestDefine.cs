namespace DataAccess.Test;

public static class UnitTest
{
    
    public static async void LoginTest(string test_login, string test_password)
    {
        LoginDataServices LoginDatabase = new LoginDataServices();

        //Code: 1
        //Перевірка корекності Логіну та паролю
        Console.WriteLine("TC1.1");
        if (await LoginDatabase.LoginIn(test_login, test_login) == 0)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");

        //Code: -1
        //Перевірка корекності Логіну
        Console.WriteLine("TC1.2");
        if (await LoginDatabase.LoginIn(test_login, test_login) == -1)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");

        //Code: -2
        //Перевірка корекності Паролю
        Console.WriteLine("TC1.3");
        if (await LoginDatabase.LoginIn(test_login, test_login) == -2)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");

        //Code: -3
        //Перевірка на існування вказаного облікового запису
        Console.WriteLine("TC1.x");
        if (await LoginDatabase.LoginIn(test_login, test_login) == -3)
            Console.WriteLine("\tPassed");
        else
            Console.WriteLine("\tFailed");
    }

}
