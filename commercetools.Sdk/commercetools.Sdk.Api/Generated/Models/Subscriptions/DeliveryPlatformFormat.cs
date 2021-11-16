namespace commercetools.Api.Models.Subscriptions
{
    public partial class DeliveryPlatformFormat : IDeliveryPlatformFormat
    {
        public string Type { get; set; }
        public DeliveryPlatformFormat()
        {
            this.Type = "Platform";
        }
    }
}
