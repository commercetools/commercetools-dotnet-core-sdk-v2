namespace commercetools.Sdk.Api.Models.Subscriptions
{
    public partial class IronMqDestination : IIronMqDestination
    {
        public string Type { get; set; }

        public string Uri { get; set; }
        public IronMqDestination()
        {
            this.Type = "IronMQ";
        }
    }
}
