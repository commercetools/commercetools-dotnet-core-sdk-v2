namespace commercetools.Sdk.Api.Models.Orders
{
    public partial class OrderSearchRequest : IOrderSearchRequest
    {
        public IOrderSearchQuery Query { get; set; }

        public string Sort { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
