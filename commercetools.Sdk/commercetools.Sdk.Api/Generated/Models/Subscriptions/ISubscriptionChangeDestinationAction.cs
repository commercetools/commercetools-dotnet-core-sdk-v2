using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionChangeDestinationAction))]
    public partial interface ISubscriptionChangeDestinationAction : ISubscriptionUpdateAction
    {
        IDestination Destination { get; set; }
    }
}
