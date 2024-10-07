

namespace commercetools.Sdk.Api.Models.Subscriptions
{

    public partial class PlatformFormat : IPlatformFormat
    {
        public string Type { get; set; }
        public PlatformFormat()
        {
            this.Type = "Platform";
        }
    }
}
