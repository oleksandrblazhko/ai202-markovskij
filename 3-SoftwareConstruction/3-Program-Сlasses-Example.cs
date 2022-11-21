public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public LoginData UserData { get; set; }
}

public class LoginData
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Login { get; set; }
    public string Email { get; set; }
    public DateTime CreatedDate { get; } = DateTime.Now;
    public string Password { get; set; } = "test_test";
}

