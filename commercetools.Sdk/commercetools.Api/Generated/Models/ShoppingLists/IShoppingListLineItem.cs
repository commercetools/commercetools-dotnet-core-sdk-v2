using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using commercetools.Api.Generated.Models.Products;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ShoppingLists
{
    public interface IShoppingListLineItem 
    {
        DateTime AddedAt { get; set;}
        
        ICustomFields Custom { get; set;}
        
        DateTime DeactivatedAt { get; set;}
        
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        string ProductId { get; set;}
        
        ILocalizedString ProductSlug { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        int Quantity { get; set;}
        
        IProductVariant Variant { get; set;}
        
        long VariantId { get; set;}
    }
}
