using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace ApprooviaApi.Models
{
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