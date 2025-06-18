// Models/User.cs
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KeployMongoSample.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }
    }
}
