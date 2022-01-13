using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Subscriptions;
using commercetools.Base.Serialization;

namespace commercetools.Sdk.Api.Serialization.JsonConverters
{
    public class MessageDeliveryConverter: JsonConverter<MessageDelivery>
    {
        private readonly ISerializerService _serializerService;

        internal MessageDeliveryConverter(ISerializerService serializerService)
        {
            this._serializerService = serializerService;
        }

        public override MessageDelivery Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var jsonDocument = JsonDocument.ParseValue(ref reader);
            MessageDelivery messageDelivery = new MessageDelivery();
            var rootElement = jsonDocument.RootElement;
            if (rootElement.ValueKind == JsonValueKind.Object)
            {
                messageDelivery.Id = rootElement.GetProperty("id").GetString();
                messageDelivery.Version = rootElement.GetProperty("version").GetInt64();
                messageDelivery.NotificationType = rootElement.GetProperty("notificationType").GetString();
                messageDelivery.ProjectKey = rootElement.GetProperty("projectKey").GetString();
                messageDelivery.ResourceVersion = rootElement.GetProperty("resourceVersion").GetInt64();
                messageDelivery.SequenceNumber = rootElement.GetProperty("sequenceNumber").GetInt64();
                if (rootElement.TryGetProperty("createdAt", out var createdAt))
                {
                    messageDelivery.CreatedAt = createdAt.GetDateTime();
                }
                if (rootElement.TryGetProperty("lastModifiedAt", out var lastModifiedAt))
                {
                    messageDelivery.LastModifiedAt = lastModifiedAt.GetDateTime();
                }
                if (rootElement.TryGetProperty("payloadNotIncluded", out var payloadNotIncluded))
                {
                    messageDelivery.PayloadNotIncluded = payloadNotIncluded.ToObject<IPayloadNotIncluded>(_serializerService);
                }
                if (rootElement.TryGetProperty("resource", out var resource))
                {
                    messageDelivery.Resource = resource.ToObject<IReference>(_serializerService);
                }
                if (rootElement.TryGetProperty("resourceUserProvidedIdentifiers",
                    out var resourceUserProvidedIdentifiers))
                {
                    messageDelivery.ResourceUserProvidedIdentifiers = resourceUserProvidedIdentifiers
                        .ToObject<IUserProvidedIdentifiers>(_serializerService);
                }
                messageDelivery.Message = rootElement.ToObject<IMessage>(_serializerService);
            }

            return messageDelivery;
        }

        public override void Write(Utf8JsonWriter writer, MessageDelivery value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }

}