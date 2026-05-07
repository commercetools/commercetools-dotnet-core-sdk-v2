using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace commercetools.Sdk.ImportApi.Serialization
{
    /// <summary>
    /// Import API specific datetime converter.
    /// Writes UTC values in canonical +00:00 form to avoid lexical mismatches
    /// with systems that compare date-time strings instead of parsed instants.
    /// </summary>
    public class ImportDateTimeConverter : JsonConverter<DateTime>
    {
        private const string UtcInstantCoreFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFF";

        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTime.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal);
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            var utc = value.ToUniversalTime();
            var formatted = utc.ToString(UtcInstantCoreFormat, CultureInfo.InvariantCulture) + "+00:00";

            // Write canonical text without escaping '+' to '\u002B'.
            writer.WriteRawValue($"\"{formatted}\"", skipInputValidation: false);
        }
    }
}
