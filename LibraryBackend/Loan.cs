namespace LibraryBackend;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class LoanDTO
{
    public string StudentId { get; set; }
    public string BookId { get; set; }
    public DateTime LoanDate { get; set; }
    public DateTime ?ReturnDate { get; set; }
}

public class LoanModel : LoanDTO
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
}
