using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetProductPriceCustomFieldAction))]
    public partial interface IProductSetProductPriceCustomFieldAction : IProductUpdateAction
    {
        string PriceId { get; set;}
        
        bool? Staged { get; set;}
        
        string Name { get; set;}
        
        Object Value { get; set;}
    }
}
