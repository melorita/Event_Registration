using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace EventRegistration.API.Services
{
    public class JavaScriptDateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                string dateStr = reader.GetString();
                
                // Handle "/Date(123456789)/" format
                var match = Regex.Match(dateStr, @"/Date\((\d+)\)/");
                if (match.Success)
                {
                    long ticks = long.Parse(match.Groups[1].Value);
                    return DateTimeOffset.FromUnixTimeMilliseconds(ticks).DateTime;
                }

                if (DateTime.TryParse(dateStr, out DateTime dt))
                {
                    return dt;
                }
            }
            return reader.GetDateTime();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));
        }
    }
}
