using ApprooviaApi.Models;
using System.Collections.Generic;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace ApprooviaApi.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;
        // I connected to the mongoDB driver that allows connection to mongo databse. 
        // I specified the connection string as DB 
        // I specified that the name of the database is sparkpug and the name of the collection is usercollection 
        public UserService(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetConnectionString("DB"));
            var database = client.GetDatabase("sparkpug");
            _users = database.GetCollection<User>("UserCollection");
        }
        // Now I want to execute the post request. 
        public User PostUser(User user)
        {
            _users.InsertOne(user);
            return user;
        }
    }
}