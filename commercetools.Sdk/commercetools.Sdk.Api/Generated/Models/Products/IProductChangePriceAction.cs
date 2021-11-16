using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductChangePriceAction))]
    public partial interface IProductChangePriceAction : IProductUpdateAction
    {
        string PriceId { get; set;}
        
        IPriceDraft Price { get; set;}
        
        bool? Staged { get; set;}
    }
}
