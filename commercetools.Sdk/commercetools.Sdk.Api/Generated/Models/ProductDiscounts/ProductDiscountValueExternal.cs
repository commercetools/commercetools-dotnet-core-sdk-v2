namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueExternal : IProductDiscountValueExternal
    {
        public string Type { get; set; }
        public ProductDiscountValueExternal()
        {
            this.Type = "external";
        }
    }
}
