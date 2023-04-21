namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchQueryExpressionValue : IOrderSearchQueryExpressionValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public string CustomType { get; set; }
    }
}
