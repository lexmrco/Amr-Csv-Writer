using CsvHelper.Configuration.Attributes;
using System;

namespace Learning.Csv
{
    public class EventlogCsvModel
    {
        [Name("createdAt")]
        public string CreatedAt { get; set; }

        [Name("traceKey")]
        public string TraceKey { get; set; }

        [Name("traceValue")]
        public string TraceValue { get; set; }

        [Name("companyId")]
        public string CompanyId { get; set; }

        [Name("apiKey")]
        public string ApiKey { get; set; }

        [Name("message")]
        public string Message { get; set; }

        [Name("user")]
        public string User { get; set; }

        [Name("payload")]
        public string Payload { get; set; }

        [Name("tags")]
        public string Tags { get; set; }
    }
}
