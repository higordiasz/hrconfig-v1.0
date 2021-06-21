using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConfig.Model
{
    public class Criador
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("Email")]
        [BsonRequired()]
        public string Email { get; set; }

        [BsonElement("Gmail")]
        [BsonRequired()]
        public Boolean Gmail { get; set; }

        [BsonElement("Instagram")]
        [BsonRequired()]
        public Boolean Instagram { get; set; }

    }
}
