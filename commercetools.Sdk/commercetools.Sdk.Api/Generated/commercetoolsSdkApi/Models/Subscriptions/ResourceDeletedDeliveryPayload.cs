using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class ResourceDeletedDeliveryPayload : IResourceDeletedDeliveryPayload
    {
        public string ProjectKey { get; set; }

        public string NotificationType { get; set; }

        public IReference Resource { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public long Version { get; set; }

        public DateTime ModifiedAt { get; set; }

        public bool? DataErasure { get; set; }
        public ResourceDeletedDeliveryPayload()
        {
            this.NotificationType = "ResourceDeleted";
        }
    }
}
