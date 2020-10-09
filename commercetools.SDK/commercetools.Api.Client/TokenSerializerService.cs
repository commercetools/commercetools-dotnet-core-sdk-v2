using System;
using System.Text.Json;
using commercetools.Api.Serialization;

namespace commercetools.Api.Client
{
    public class TokenSerializerService : ITokenSerializerService
    {
        private readonly JsonSerializerOptions jsonSerializerOptions;

        public TokenSerializerService()
        {
            jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = SnakeCaseNamingPolicy.Instance
            };
        }

        public T Deserialize<T>(string input)
        {
            return JsonSerializer.Deserialize<T>(input, jsonSerializerOptions);
        }

        public object Deserialize(Type returnType, string input)
        {
            return JsonSerializer.Deserialize(input, returnType, jsonSerializerOptions);
        }

        public string Serialize<T>(T input)
        {
            return JsonSerializer.Serialize<T>(input, jsonSerializerOptions);
        }
    }
}
