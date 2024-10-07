

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class AzureEventGridDestination : IAzureEventGridDestination
    {
        public string Type { get; set; }

        public string Uri { get; set; }

        public string AccessKey { get; set; }
        public AzureEventGridDestination()
        {
            this.Type = "EventGrid";
        }
    }
}
