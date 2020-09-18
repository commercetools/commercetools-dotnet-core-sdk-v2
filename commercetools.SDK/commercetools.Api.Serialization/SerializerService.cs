using System.Text.Json;
using commercetools.Api.Registration;
using commercetools.Api.Serialization.JsonConverters;

namespace commercetools.Api.Serialization
{
    public class SerializerService : ISerializerService
    {
        private readonly JsonSerializerOptions _serializerOptions;
       
        public SerializerService(ITypeRetriever typeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            _serializerOptions.Converters.Add(new AbstractClassConverterFactory(
                _serializerOptions.PropertyNamingPolicy, typeRetriever));
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
