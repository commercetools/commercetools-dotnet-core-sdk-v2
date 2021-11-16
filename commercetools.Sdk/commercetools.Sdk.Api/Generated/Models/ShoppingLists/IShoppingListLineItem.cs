using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListLineItem))]
    public partial interface IShoppingListLineItem 
    {
        DateTime AddedAt { get; set;}
        
        ICustomFields Custom { get; set;}
        
        DateTime? DeactivatedAt { get; set;}
        
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        string ProductId { get; set;}
        
        ILocalizedString ProductSlug { get; set;}
        
        IProductTypeReference ProductType { get; set;}
        
        int Quantity { get; set;}
        
        IProductVariant Variant { get; set;}
        
        long? VariantId { get; set;}
    }
}
