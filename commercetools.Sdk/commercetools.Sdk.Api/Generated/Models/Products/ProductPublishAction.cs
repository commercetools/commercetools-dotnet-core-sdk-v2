using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.Products
{
    public partial class ProductPublishAction : IProductPublishAction
    {
        public string Action { get; set;}
        
        public IProductPublishScope Scope { get; set;}
        public ProductPublishAction()
        { 
           this.Action = "publish";
        }
    }
}
