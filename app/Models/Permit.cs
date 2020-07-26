using System;
//using Cassandra;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace app.Models
{
    public class Permit
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        [BsonElement("permitnum")]
        public string permitnum { get; set; }
        [BsonElement("permit_type")]
        public string permit_type { get; set; }
        [BsonElement("permit_subtype")]
        public string permit_subtype { get; set; }
        [BsonElement("category")]
        public string category { get; set; }
        [BsonElement("address_full")]
        public string address_full { get; set; }
        [BsonElement("issue_date")]
        public string issue_date { get; set; }
        [BsonElement("status")]
        public string status { get; set; }
        [BsonElement("status_date")]
        public string status_date { get; set; }
        [BsonElement("valuation")]
        [BsonRepresentation(BsonType.Int64, AllowTruncation = true)]
        public int valuation { get; set; }
        [BsonElement("longitude")]
        public double longitude { get; set; }
        [BsonElement("latitude")]
        public double latitude { get; set; }

        [BsonElement("contractor_business_name")]
        public string contractor_business_name { get; set; }

    }
}
 