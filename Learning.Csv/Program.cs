using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Learning.Csv
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteEventlogsCsv();
            WriteTrackTableCsv();
        }

        private static void WriteEventlogsCsv()
        {
            Console.WriteLine("WriteCsv");
            var data = new[]
            {
               new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "phoneNumber",
                    TraceValue = "3021234567",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    LogType = "INFO",
                    Message = "Message enqueue in Primary queue.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "campaignId,accountId"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "phoneNumber",
                    TraceValue = "3021234567",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    LogType = "INFO",
                    Message = "Message persisted in DBConnectin",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"messageId\":\"002D03B5-7623-4C48-BA4A-3D1D881083DA\",\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "messageId,campaignId,accountId"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "phoneNumber",
                    TraceValue = "3021234567",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "hubout",
                    LogType = "INFO",
                    Message = "Messagehandler. Message enqueue in outbox queue.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "phoneNumber",
                    TraceValue = "3021234567",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "hubout",
                    LogType = "INFO",
                    Message = "MessagehandlerSend. Message Delivered.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A"
                },
                new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "phoneNumber",
                    TraceValue = "3021234567",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "hubout",
                    LogType = "INFO",
                    Message = "MessagehandlerSend. Persisted in DynamoDB.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A"
                },
                new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "campaignId",
                    TraceValue = "99371B37-2475-4F4E-B92D-5CFEF2436A20",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    LogType = "ERROR",
                    Message = "insufficient balance",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"messageId\":\"002D03B5-7623-4C48-BA4A-3D1D881083DA\",\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "messageId,campaignId,accountId"
                },
                new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "campaignId-messageId",
                    TraceValue = "22759044-34F3-49CF-A582-474BC15B9D5B-EA8EA3E3-A4A9-406B-B6AF-EE822DC25D7C",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    LogType = "INFO",
                    Message = "Message enqueue in Primary queue.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "campaignId,accountId"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "campaignId-messageId",
                    TraceValue = "22759044-34F3-49CF-A582-474BC15B9D5B-EA8EA3E3-A4A9-406B-B6AF-EE822DC25D7C",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    LogType = "INFO",
                    Message = "Message persisted in DBConnectin",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"messageId\":\"002D03B5-7623-4C48-BA4A-3D1D881083DA\",\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "messageId,campaignId,accountId"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "campaignId-messageId",
                    TraceValue = "22759044-34F3-49CF-A582-474BC15B9D5B-EA8EA3E3-A4A9-406B-B6AF-EE822DC25D7C",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "hubout",
                    LogType = "INFO",
                    Message = "Messagehandler. Message enqueue in outbox queue.",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A"
                },
                 new EventlogQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    TraceKey = "campaignId-messageId",
                    TraceValue = "22759044-34F3-49CF-A582-474BC15B9D5B-EA8EA3E3-A4A9-406B-B6AF-EE822DC25D7C",
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "hubout",
                    LogType = "ERROR",
                    Message = "SMS Channel return ERROR 401. Invalid credentials",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    Payload = "{\"messageId\":\"002D03B5-7623-4C48-BA4A-3D1D881083DA\",\"campaignId\":\"35B4AC0D-98FA-4FC2-A518-F65CC681C3BB\",\"accountId\":\"B29EE303-C5A4-4346-95B9-3BCA64DF1A04\"}",
                    Tags = "messageId,campaignId,accountId"
                }
            };

            foreach (var item in data)
            {
                var csvRecord = new EventlogCsvModel
                {
                    CreatedAt = item.CreatedAt,
                    TraceKey = item.TraceKey,
                    TraceValue = item.TraceValue,
                    CompanyId = item.CompanyId,
                    ApiKey = item.ApiKey,
                    Message = item.Message,
                    User = item.User,
                    Tags = item.Tags,
                    Payload = item.Payload
                };
                if (DateTime.TryParse(item.CreatedAt, out DateTime createdAt))
                    createdAt = DateTime.Now;
                WriteCsv<EventlogCsvModel>("connectin", "eventlogs", item.LogType, createdAt, csvRecord);
            }

        }

        private static void WriteCsv<TCsvData>(string appName, string traceType,string logType, DateTime createdAt, TCsvData record)
        {
            string basePath = string.Format(
                @"c:\temp\{0}\{1:D4}\{2:D2}\{3:D2}",
                traceType,
                createdAt.Year,
                createdAt.Month,
                createdAt.Day);
            string path = string.Format(@"{0}\{1}-{2}.csv", basePath, appName, logType.ToLower());
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
            bool existsFile = File.Exists(path);
            CsvConfiguration csvConfiguration = new CsvConfiguration(CultureInfo.GetCultureInfo("en"))
            {
                Delimiter = ";",
                HasHeaderRecord = !existsFile,
                ShouldQuote = (field) =>
                {
                    return true;
                }
            };

            using var writer = File.AppendText(path);
            using var csvWriter = new CsvWriter(writer, csvConfiguration);
            if (!existsFile)
            {
                csvWriter.WriteHeader<TCsvData>();
            }
            csvWriter.NextRecord();
            csvWriter.WriteRecord(record);

            writer.Flush();
        }
        private static void WriteTrackTableCsv()
        {
            Console.WriteLine("WriteCsv");
            var data = new[]
            {
                new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    Action = "CREATE",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    TableName = "public.configchannels",
                    RecordId = "2"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    Action = "CREATE",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    TableName = "public.accounts",
                    RecordId = "25e3746e-22fa-4ece-95c9-8530c2f2e3ac"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    Action = "UPDATE",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    TableName = "public.accounts",
                    RecordId = "25e3746e-22fa-4ece-95c9-8530c2f2e3ac",
                    Payload = "{\"oldName\":\"Servicio al cliente\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    CompanyId = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    ApiKey = "connectin-backend",
                    Action = "DELETE",
                    User = "F8EA8F60-D02D-4BF4-846C-2094D110C76A",
                    TableName = "public.accounts",
                    RecordId = "25e3746e-22fa-4ece-95c9-8530c2f2e3ac",
                    Payload = "{\"Name\":\"Servicio al cliente\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGIN",
                    CompanyId = "31688AB9-F9C9-45D8-955E-C433182F774C",
                    User = "user1@testing.com",
                    Payload = "{\"status\":\"success\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGOUT",
                    CompanyId = "31688AB9-F9C9-45D8-955E-C433182F774C",
                    User = "user1@testing.com",
                    Payload = "{\"status\":\"success\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGIN",
                    User = "aa@a.com",
                    Payload = "{\"status\":\"Unregistered User\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGIN",
                    User = "user1@testingcorp.com",
                    Payload = "{\"status\":\"Password incorrect\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGIN",
                    User = "user2@testingcorp.com",
                    Payload = "{\"status\":\"Inactive user\"}"
                },
                 new TracktableQueueModel() {
                    CreatedAt = string.Format("{0:yyyy-MM-ddTHH:mm:ss.fffZ}", DateTime.UtcNow),
                    ApiKey = "connectin-backend",
                    Action = "LOGIN",
                    User = "user@company2.com",
                    Payload = "{\"status\":\"Inactive company\"}"
                }
            };

            foreach (var item in data)
            {
                var csvRecord = new TracktableCsvModel
                {
                    CreatedAt = item.CreatedAt,
                    CompanyId = item.CompanyId,
                    ApiKey = item.ApiKey,
                    Action = item.Action,
                    User = item.User,
                    RecordId = item.RecordId,
                    Payload = item.Payload
                };
                DateTime createdAt = Convert.ToDateTime(item.CreatedAt);
                string logType = item.TableName;
                if (string.IsNullOrEmpty(item.TableName))
                    if (item.Action == "LOGIN" || item.Action == "LOGOUT")
                        logType = "LOGIN";
                    else
                        logType = item.Action;
                WriteCsv<TracktableCsvModel>("connectin", "tracktable", logType, createdAt, csvRecord);
            }           
        }
    }
}
