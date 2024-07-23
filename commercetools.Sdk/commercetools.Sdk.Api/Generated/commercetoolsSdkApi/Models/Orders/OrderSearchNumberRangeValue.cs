namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSearchNumberRangeValue : IOrderSearchNumberRangeValue
    {
        public string Field { get; set; }

        public int? Boost { get; set; }

        public IOrderSearchCustomType CustomType { get; set; }

        public decimal? Gte { get; set; }

        public decimal? Lte { get; set; }
    }
}
