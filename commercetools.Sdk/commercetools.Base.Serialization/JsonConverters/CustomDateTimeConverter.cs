using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace commercetools.Base.Serialization.JsonConverters
{
    public class CustomDateTimeConverter : JsonConverter<DateTime>
    {
        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToUniversalTime().ToString(DefaultDateTimeFormat));
        }
    }
}