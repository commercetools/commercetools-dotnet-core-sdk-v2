using System.Text.Json;
using commercetools.Base.Registration;
using commercetools.Base.Serialization.JsonConverters;
using Type = System.Type;

namespace commercetools.Base.Serialization
{
    public class BaseSerializerService : ISerializerService
    {
        protected readonly JsonSerializerOptions _serializerOptions;
       
        public BaseSerializerService(
            ITypeRetriever typeRetriever)
        {
            _serializerOptions = new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
            _serializerOptions.Converters.Add(new CustomDateTimeConverter());
            _serializerOptions.Converters.Add(new AbstractClassConverterFactory(
                _serializerOptions.PropertyNamingPolicy, _serializerOptions, typeRetriever));
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, _serializerOptions);
        }
        
        public object Deserialize(Type returnType,string input)
        {
            return JsonSerializer.Deserialize(input, returnType, _serializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, _serializerOptions);
        }
    }
}
