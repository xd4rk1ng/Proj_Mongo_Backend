namespace LibraryBackend;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class BookDTO
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class BookModel : BookDTO
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}