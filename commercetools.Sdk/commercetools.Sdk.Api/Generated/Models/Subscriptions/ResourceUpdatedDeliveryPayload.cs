using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class ResourceUpdatedDeliveryPayload : IResourceUpdatedDeliveryPayload
    {
        public string ProjectKey { get; set; }

        public string NotificationType { get; set; }

        public IReference Resource { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

        public long Version { get; set; }

        public long OldVersion { get; set; }

        public DateTime ModifiedAt { get; set; }
        public ResourceUpdatedDeliveryPayload()
        {
            this.NotificationType = "ResourceUpdated";
        }
    }
}
