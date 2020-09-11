using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace app.Models
{
    public class Contractor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        [BsonElement("contractor_business_name")]
        public string contractors_business_name { get; set; }

        [BsonElement("address")]
        public string address { get; set; }
        [BsonElement("city")]
        public string city { get; set; }

        [BsonElement("state")]
        public string state { get; set; }

        [BsonElement("license_num")]
        public int license_number { get; set; }

        [BsonElement("license_type")]
        public string license_type { get; set; }

        [BsonElement("license_expire_date")]
        public string license_expire_date { get; set; }
    }
    public class Rank
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }

        [BsonElement("contractor_business_name")]
        public string contractor_business_name { get; set; }

        [BsonElement("rating")]
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public Decimal128? rating { get; set; }

        [BsonElement("total_ratings")]
        public string total_ratings { get; set; }

        [BsonElement("business_category")]
        public string business_category { get; set; }

        [BsonElement("website")]
        public string website { get; set; }
    }


}
