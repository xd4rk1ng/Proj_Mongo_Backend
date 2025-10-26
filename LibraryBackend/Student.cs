namespace LibraryBackend;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class StudentDTO
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class StudentModel : StudentDTO
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}