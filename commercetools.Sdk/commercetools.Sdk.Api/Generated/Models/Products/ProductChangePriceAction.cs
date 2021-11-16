using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Products
{
    public partial class ProductChangePriceAction : IProductChangePriceAction
    {
        public string Action { get; set;}
        
        public string PriceId { get; set;}
        
        public IPriceDraft Price { get; set;}
        
        public bool? Staged { get; set;}
        public ProductChangePriceAction()
        { 
           this.Action = "changePrice";
        }
    }
}
