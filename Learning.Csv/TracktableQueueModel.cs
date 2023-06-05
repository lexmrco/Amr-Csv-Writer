using Newtonsoft.Json;
using System;

namespace Learning.Csv
{
    public class TracktableQueueModel
    {
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("tableName")]
        public string TableName { get; set; }


        [JsonProperty("recordId")]
        public string RecordId { get; set; }


        [JsonProperty("payload")]
        public string Payload { get; set; }
    }
}
