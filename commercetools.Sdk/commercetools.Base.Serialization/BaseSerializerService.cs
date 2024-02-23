using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Base.Registration;
using commercetools.Base.Serialization.JsonConverters;
using Type = System.Type;

namespace commercetools.Base.Serialization
{
    public class BaseSerializerService : IStreamSerializerService
    {
        protected readonly JsonSerializerOptions _serializerOptions;

        public BaseSerializerService(
            ITypeRetriever typeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            };
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new CustomDateConverter());
            _serializerOptions.Converters.Add(new DeserializeAsConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
            _serializerOptions.Converters.Add(new EnumAsInterfaceConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
            _serializerOptions.Converters.Add(new TypeDiscriminatorConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions));
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }

        public T Deserialize<T>(Stream inputStream)
        {
            return JsonSerializer.Deserialize<T>(inputStream, _serializerOptions);
        }

        public object Deserialize(Type returnType, string input)
        {
            return JsonSerializer.Deserialize(input, returnType, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
