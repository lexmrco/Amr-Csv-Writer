using Newtonsoft.Json;
using System;

namespace Learning.Csv
{
    public class EventlogQueueModel
    {
        [JsonProperty("CreatedAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("traceKey")]
        public string TraceKey { get; set; }

        [JsonProperty("traceValue")]
        public string TraceValue { get; set; }

        [JsonProperty("companyId")]
        public string CompanyId { get; set; }

        [JsonProperty("apiKey")]
        public string ApiKey { get; set; }

        [JsonProperty("logType")]
        public string LogType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("alertPayload")]
        public string AlertPayload { get; set; }
    }
}
