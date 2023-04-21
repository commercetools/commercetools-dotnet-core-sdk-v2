namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchLongRangeValue : IOrderSearchLongRangeValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public string CustomType { get; set; }

        public long? Gte { get; set; }

        public long? Lte { get; set; }
    }
}
