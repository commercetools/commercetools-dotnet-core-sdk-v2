using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.DeliveryPayload))]
    public partial interface IDeliveryPayload : ISubscriptionNotification
    {
        string ProjectKey { get; set; }

        IReference Resource { get; set; }

        IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set; }

    }
}
