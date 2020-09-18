using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListLineItem 
    {
        public DateTime AddedAt { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public DateTime DeactivatedAt { get; set;}
        
        public string Id { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public string ProductId { get; set;}
        
        public LocalizedString ProductSlug { get; set;}
        
        public ProductTypeReference ProductType { get; set;}
        
        public int Quantity { get; set;}
        
        public ProductVariant Variant { get; set;}
        
        public long VariantId { get; set;}
    }
}
