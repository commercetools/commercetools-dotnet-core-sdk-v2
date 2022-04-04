using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.SubscriptionChangeDestinationAction))]
    public partial interface ISubscriptionChangeDestinationAction : ISubscriptionUpdateAction
    {
        IDestination Destination { get; set; }
    }
}
