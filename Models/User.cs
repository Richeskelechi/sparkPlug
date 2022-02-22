using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ApprooviaApi.Models
{
    // I created a class user which will model the content that will be stored in the database.
    // the collection in the mongoDB will have an ID, Name, Email and Message field 
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement]
        public string Name { get; set; }
        [BsonElement]
        public string Email { get; set; }
        [BsonElement]
        public string Message { get; set; }
    }
}