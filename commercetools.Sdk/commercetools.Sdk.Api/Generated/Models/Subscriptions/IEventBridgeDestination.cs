using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Subscriptions.EventBridgeDestination))]
    public partial interface IEventBridgeDestination : IDestination
    {
        string Region { get; set; }

        string AccountId { get; set; }

    }
}
