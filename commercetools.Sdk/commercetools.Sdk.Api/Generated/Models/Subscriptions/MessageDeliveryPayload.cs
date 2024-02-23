using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class MessageDeliveryPayload : IMessageDeliveryPayload
    {
        public string ProjectKey { get; set; }

        public string NotificationType { get; set; }

        public IReference Resource { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public long SequenceNumber { get; set; }

        public long ResourceVersion { get; set; }

        public IPayloadNotIncluded PayloadNotIncluded { get; set; }
        public MessageDeliveryPayload()
        {
            this.NotificationType = "Message";
        }
    }
}
