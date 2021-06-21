using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRConfig.Model
{
    class Versao
    {
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("HRConfig")]
        [BsonRequired()]
        public string HRConfig { get; set; }

        [BsonElement("HRGanhar")]
        [BsonRequired()]
        public string HRGanhar { get; set; }

        [BsonElement("HRSiga")]
        [BsonRequired()]
        public string HRSiga { get; set; }
    }
}
