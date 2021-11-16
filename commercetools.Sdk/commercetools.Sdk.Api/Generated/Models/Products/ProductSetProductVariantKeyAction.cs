namespace commercetools.Api.Models.Products
{
    public partial class ProductSetProductVariantKeyAction : IProductSetProductVariantKeyAction
    {
        public string Action { get; set;}
        
        public long? VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public string Key { get; set;}
        
        public bool? Staged { get; set;}
        public ProductSetProductVariantKeyAction()
        { 
           this.Action = "setProductVariantKey";
        }
    }
}
