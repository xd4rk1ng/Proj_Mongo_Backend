using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
// Perhaps classes will be derived from a base class, with the basic mongo db adjustments


public class StudentModel
{
    /* These 2 lines and the property Id: */
    //
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    /*  - [BsonId] tells MongoDB that this property represents the "_id" field in the document.*/
    /*  - [BsonRepresentation(BsonType.ObjectId)] allows you to use a string in C#, while MongoDB stores it as an ObjectId.*/
    //--------------------------------
    /*  So:
        - In C#, the property is called Id
        - In MongoDB, it maps to the _id field*/

    public string FirstName { get; set; }
    public string LastName { get; set; }

    // So we print easier
    public override string ToString()
    {

        return $"ObjectId: {Id} -- {FirstName} {LastName}";
    }

}
