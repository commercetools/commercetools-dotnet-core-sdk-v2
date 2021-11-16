using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductChangeSlugAction : IProductChangeSlugAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Slug { get; set;}
        
        public bool? Staged { get; set;}
        public ProductChangeSlugAction()
        { 
           this.Action = "changeSlug";
        }
    }
}
