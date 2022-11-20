public class LoginDataServices
{
    private readonly IMongoCollection<LoginData> _loginData;
    private const string Connection =
        "mongodb+srv://profile:test1@cluster0.6wbdzra.mongodb.net/?retryWrites=true&w=majority";

    private const string DatabaseName =
        "application_db";


    public LoginDataServices()
    {
        var mongoClient = new MongoClient(Connection);

        _loginData = mongoClient
            .GetDatabase(DatabaseName)
            .GetCollection<LoginData>("user_login_data");
    }

    public async Task Create(LoginData newLoginData) =>
        await _loginData.InsertOneAsync(newLoginData);

    public async Task<List<LoginData>> GetAll() =>
        await _loginData.Find(_ => true).ToListAsync();

    public async Task<int> LoginIn(string login, string password)
    {

        if (login.Length < 6 || login.Length > 32)
            return -1;

        if (password.Length < 8 || password.Length > 24)
            return -2;

        LoginData userDataInDatabase;
        try
        {
            userDataInDatabase =
                       await _loginData.Find(c => c.Login == login).FirstAsync();
            
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
            Console.WriteLine($"Користувача {login} не iснує!");
            return -3;
        }
        return 0;
    }

}