// Services/UserService.cs
using KeployMongoSample.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace KeployMongoSample.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDBSettings:ConnectionString"]);
            var database = client.GetDatabase(config["MongoDBSettings:DatabaseName"]);
            _users = database.GetCollection<User>(config["MongoDBSettings:CollectionName"]);
        }

        public List<User> Get() => _users.Find(user => true).ToList();
        public User Get(string id) => _users.Find<User>(user => user.Id == id).FirstOrDefault();
        public User Create(User user) { _users.InsertOne(user); return user; }
    }
}
