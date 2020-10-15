using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CustomLineItem 
    {
        public string Id { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public TypedMoney Money { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        
        public TypedMoney TotalPrice { get; set;}
        
        public string Slug { get; set;}
        
        public long Quantity { get; set;}
        
        public List<ItemState> State { get; set;}
        
        public TaxCategoryReference TaxCategory { get; set;}
        
        public TaxRate TaxRate { get; set;}
        
        public List<DiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public ItemShippingDetails ShippingDetails { get; set;}
    }
}
