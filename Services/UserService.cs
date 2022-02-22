using ApprooviaApi.Models;
using System.Collections.Generic;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace ApprooviaApi.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;
        public UserService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("DB"));
            var database = client.GetDatabase("sparkpug");
            _users = database.GetCollection<User>("UserCollection");
        }

        public User PostUser(User user)
        {
            _users.InsertOne(user);
            return user;
        }
    }
}