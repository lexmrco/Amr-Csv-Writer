
using CsvHelper.Configuration.Attributes;
using System;

namespace Learning.Csv
{
    public class TracktableCsvModel
    {
        [Name("createdAt")]
        public string CreatedAt { get; set; }

        [Name("apiKey")]
        public string ApiKey { get; set; }

        [Name("companyId")]
        public string CompanyId { get; set; }

        [Name("action")]
        public string Action { get; set; }

        [Name("user")]
        public string User { get; set; }

        [Name("recordId")]
        public string RecordId { get; set; }

        [Name("payload")]
        public string Payload { get; set; }
    }
}
