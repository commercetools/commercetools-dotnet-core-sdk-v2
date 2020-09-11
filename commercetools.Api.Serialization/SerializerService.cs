using System.Text.Json;
namespace commercetools.Api.Serialization
{
    public class SerializerService : ISerializerService
    {
       
        public SerializerService()
        {
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                PropertyNamingPolicy =  JsonNamingPolicy.CamelCase
            });
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input);
        }
    }
}
