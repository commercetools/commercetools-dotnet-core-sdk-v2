namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class GoogleCloudPubSubDestination : IGoogleCloudPubSubDestination
    {
        public string Type { get; set; }

        public string ProjectId { get; set; }

        public string Topic { get; set; }
        public GoogleCloudPubSubDestination()
        {
            this.Type = "GoogleCloudPubSub";
        }
    }
}
