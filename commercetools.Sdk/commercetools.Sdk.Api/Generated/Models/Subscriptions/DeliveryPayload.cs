using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class DeliveryPayload : IDeliveryPayload
    {
        public string ProjectKey { get; set; }

        public string NotificationType { get; set; }

        public IReference Resource { get; set; }

        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }
    }
}
