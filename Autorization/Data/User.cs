using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Autorization.Data
{
    public class User
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Email { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }

        public User(string name, string surname,
            string email,string login, string password)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Login = login;
            Password = password;
        }

    }
}
