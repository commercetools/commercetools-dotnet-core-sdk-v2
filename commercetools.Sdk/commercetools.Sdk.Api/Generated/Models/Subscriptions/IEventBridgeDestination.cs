using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.EventBridgeDestination))]
    public partial interface IEventBridgeDestination : IDestination
    {
        string Region { get; set; }

        string AccountId { get; set; }
    }
}
