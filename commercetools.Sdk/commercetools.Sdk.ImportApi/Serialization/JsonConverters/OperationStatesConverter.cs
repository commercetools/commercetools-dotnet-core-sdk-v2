using System;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.Serialization;
using commercetools.Base.Serialization.MapperTypeRetrievers;
using commercetools.ImportApi.Models.Importsummaries;

namespace commercetools.Sdk.ImportApi.Serialization.JsonConverters
{
    public class OperationStatesConverter : JsonConverter<IOperationStates>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IOperationStates).IsAssignableFrom(typeToConvert);
        }

        public override IOperationStates Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);
            var operationStates = new OperationStates();
            var rootElement = jsonDocument.RootElement;
            if (rootElement.ValueKind == JsonValueKind.Object)
            {
                foreach (PropertyInfo prop in operationStates.GetType().GetProperties())
                {
                    var jsonValue = rootElement.GetProperty(prop.Name).GetInt64();
                    prop.SetValue(operationStates, jsonValue);
                }
            }

            return operationStates;
        }

        public override void Write(Utf8JsonWriter writer, IOperationStates value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}