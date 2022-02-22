namespace commercetools.Api.Models.Orders
{
    public partial class OrderSearchRequest : IOrderSearchRequest
    {
        public object Query { get; set; }

        public string Sort { get; set; }

        public int? Limit { get; set; }

        public int? Offset { get; set; }
    }
}
