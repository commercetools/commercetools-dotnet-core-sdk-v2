using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListLineItem : IShoppingListLineItem
    {
        public DateTime AddedAt { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public DateTime DeactivatedAt { get; set;}
        
        public string Id { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public string ProductId { get; set;}
        
        public ILocalizedString ProductSlug { get; set;}
        
        public IProductTypeReference ProductType { get; set;}
        
        public int Quantity { get; set;}
        
        public IProductVariant Variant { get; set;}
        
        public long? VariantId { get; set;}
    }
}
