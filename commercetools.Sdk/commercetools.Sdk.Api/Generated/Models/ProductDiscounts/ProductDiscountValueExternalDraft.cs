namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueExternalDraft : IProductDiscountValueExternalDraft
    {
        public string Type { get; set;}
        public ProductDiscountValueExternalDraft()
        { 
           this.Type = "external";
        }
    }
}
