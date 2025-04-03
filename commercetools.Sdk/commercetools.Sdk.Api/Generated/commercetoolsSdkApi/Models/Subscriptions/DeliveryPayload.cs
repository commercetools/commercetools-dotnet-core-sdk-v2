using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;


namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class DeliveryPayload : IDeliveryPayload
    {
        public string NotificationType { get; set; }

        public string ProjectKey { get; set; }

        public IReference Resource { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }
    }
}
