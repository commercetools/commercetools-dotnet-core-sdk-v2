using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString());
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            // In case value does not contain any time span, we are talking about date attributes or custom fields.
            // Therefore, we should not send the time span at all.
            var format = DefaultDateTimeFormat;
            if (value.TimeOfDay == new TimeSpan(0, 0, 0))
            {
                format = "yyyy-MM-dd";
            }
            writer.WriteStringValue(value.ToUniversalTime().ToString(format));
        }
    }
}