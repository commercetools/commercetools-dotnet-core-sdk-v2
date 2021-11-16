using commercetools.Api.Models.Types;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetProductPriceCustomTypeAction : IProductSetProductPriceCustomTypeAction
    {
        public string Action { get; set;}
        
        public string PriceId { get; set;}
        
        public bool? Staged { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public ProductSetProductPriceCustomTypeAction()
        { 
           this.Action = "setProductPriceCustomType";
        }
    }
}
