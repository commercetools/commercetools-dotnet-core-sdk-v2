﻿using System;
using System.IO;
using System.Text.Json;

namespace commercetools.Base.Client
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

        public T Deserialize<T>(Stream inputStream)
        {
            return JsonSerializer.Deserialize<T>(inputStream, jsonSerializerOptions);
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
