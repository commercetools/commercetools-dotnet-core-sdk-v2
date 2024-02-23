namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class EventBridgeDestination : IEventBridgeDestination
    {
        public string Type { get; set; }

        public string Region { get; set; }

        public string AccountId { get; set; }
        public EventBridgeDestination()
        {
            this.Type = "EventBridge";
        }
    }
}
