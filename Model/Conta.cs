using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace HRConfig.Model
{
    public class Account
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("Email")]
        [BsonRequired()]
        public string Email { get; set; }

        [BsonElement("Senha")]
        [BsonRequired()]
        public string Senha { get; set; }

        [BsonElement("Ganhar")]
        [BsonRequired()]
        public Boolean Ganhar { get; set; }

        [BsonElement("Siga")]
        [BsonRequired()]
        public Boolean Siga { get; set; }

        [BsonElement("Delay_a")]
        [BsonRequired()]
        public int Delay_a { get; set; }

        [BsonElement("Delay_b")]
        [BsonRequired()]
        public int Delay_b { get; set; }

        [BsonElement("Delay_c")]
        [BsonRequired()]
        public int Delay_c { get; set; }

        [BsonElement("Delay_block")]
        [BsonRequired()]
        public int Delay_block { get; set; }

        [BsonElement("Challenge")]
        [BsonRequired()]
        public Boolean Challenge { get; set; }

        [BsonElement("Qtd")]
        [BsonRequired()]
        public int Qtd { get; set; }

    }
}
