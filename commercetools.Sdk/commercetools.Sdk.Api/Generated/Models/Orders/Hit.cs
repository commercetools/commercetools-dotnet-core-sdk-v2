namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class Hit : IHit
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public decimal Relevance { get; set; }
    }
}
