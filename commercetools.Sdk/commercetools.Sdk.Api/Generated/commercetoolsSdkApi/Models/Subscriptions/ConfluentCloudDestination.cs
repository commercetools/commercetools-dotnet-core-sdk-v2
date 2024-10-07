

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class ConfluentCloudDestination : IConfluentCloudDestination
    {
        public string Type { get; set; }

        public string BootstrapServer { get; set; }

        public string ApiKey { get; set; }

        public string ApiSecret { get; set; }

        public string Acks { get; set; }

        public string Topic { get; set; }

        public string Key { get; set; }
        public ConfluentCloudDestination()
        {
            this.Type = "ConfluentCloud";
        }
    }
}
