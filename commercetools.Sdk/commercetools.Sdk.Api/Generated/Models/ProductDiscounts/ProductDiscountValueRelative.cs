namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueRelative : IProductDiscountValueRelative
    {
        public string Type { get; set; }

        public long Permyriad { get; set; }
        public ProductDiscountValueRelative()
        {
            this.Type = "relative";
        }
    }
}
