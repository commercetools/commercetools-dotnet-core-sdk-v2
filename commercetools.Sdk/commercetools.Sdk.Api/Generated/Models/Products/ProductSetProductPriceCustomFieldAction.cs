using System;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetProductPriceCustomFieldAction : IProductSetProductPriceCustomFieldAction
    {
        public string Action { get; set;}
        
        public string PriceId { get; set;}
        
        public bool? Staged { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public ProductSetProductPriceCustomFieldAction()
        { 
           this.Action = "setProductPriceCustomField";
        }
    }
}
