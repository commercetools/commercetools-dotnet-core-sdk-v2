using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetMetaDescriptionAction : IProductSetMetaDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString MetaDescription { get; set;}
        
        public bool? Staged { get; set;}
        public ProductSetMetaDescriptionAction()
        { 
           this.Action = "setMetaDescription";
        }
    }
}
