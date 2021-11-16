namespace commercetools.Api.Models.Subscriptions
{
    public partial class AzureServiceBusDestination : IAzureServiceBusDestination
    {
        public string Type { get; set; }

        public string ConnectionString { get; set; }
        public AzureServiceBusDestination()
        {
            this.Type = "AzureServiceBus";
        }
    }
}
