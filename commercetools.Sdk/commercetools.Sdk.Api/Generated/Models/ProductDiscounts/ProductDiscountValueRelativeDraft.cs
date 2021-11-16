namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueRelativeDraft : IProductDiscountValueRelativeDraft
    {
        public string Type { get; set;}
        
        public long Permyriad { get; set;}
        public ProductDiscountValueRelativeDraft()
        { 
           this.Type = "relative";
        }
    }
}
