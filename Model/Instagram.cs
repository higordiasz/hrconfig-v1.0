using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HRConfig.Model
{
    public class Instagram
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("Email")]
        [BsonRequired()]
        public string Email { get; set; }

        [BsonElement("Conta")]
        [BsonRequired()]
        public string Conta { get; set; }

        [BsonElement("Senha")]
        [BsonRequired()]
        public string Senha { get; set; }

    }
}
