namespace commercetools.Api.Models.Subscriptions
{
    public partial class DeliveryCloudEventsFormat : IDeliveryCloudEventsFormat
    {
        public string Type { get; set;}
        
        public string CloudEventsVersion { get; set;}
        public DeliveryCloudEventsFormat()
        { 
           this.Type = "CloudEvents";
        }
    }
}
