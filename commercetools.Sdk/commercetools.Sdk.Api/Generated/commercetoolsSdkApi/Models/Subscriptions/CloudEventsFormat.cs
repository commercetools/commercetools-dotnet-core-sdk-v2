

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class CloudEventsFormat : ICloudEventsFormat
    {
        public string Type { get; set; }

        public string CloudEventsVersion { get; set; }
        public CloudEventsFormat()
        {
            this.Type = "CloudEvents";
        }
    }
}
