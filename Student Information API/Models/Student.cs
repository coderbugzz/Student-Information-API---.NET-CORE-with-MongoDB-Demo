using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace Student_Information_API.Models
{
    [BsonIgnoreExtraElements]
    public class Student
    {
        [BsonId]
        
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }

        [BsonElement("courses")]
        public string[]? Courses { get; set; }

        [BsonElement("gender")]
        public string Gender { get; set; } = String.Empty;

        [BsonElement("age")]
        public int Age { get; set; }
    }
}
