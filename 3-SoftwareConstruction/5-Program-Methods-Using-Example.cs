LoginDataServices db = new LoginDataServices();

LoginData newData = new LoginData()
{
    Login = "Mojahed",
    Email = "test@gmail.com",
    Password = "12345678"
};

var list = await db.GetAll();

foreach(var item in list)
{
    var json = new JavaScriptSerializer().Serialize(item);
    Console.WriteLine(json);
}

//Code -1
string login = "Moj";
string password = "12345678";

var account = await db.LoginIn(login, password);

Console.WriteLine(account);

//Code -2
login = "Mojahed";
password = "123";

var account2 = await db.LoginIn(login, password);

Console.WriteLine(account2);

//Code -3
login = "Mojahed21";
password = "12345678";

var account3 = await db.LoginIn(login, password);

Console.WriteLine(account3);