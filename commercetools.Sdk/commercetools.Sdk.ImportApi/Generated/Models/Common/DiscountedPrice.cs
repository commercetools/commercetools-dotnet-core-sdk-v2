namespace commercetools.ImportApi.Models.Common
{
    public partial class DiscountedPrice : IDiscountedPrice
    {
        public ITypedMoney Value { get; set; }

        public IProductDiscountKeyReference Discount { get; set; }
    }
}
