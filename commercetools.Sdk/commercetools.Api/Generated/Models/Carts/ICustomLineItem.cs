using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.TaxCategories;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface ICustomLineItem 
    {
        string Id { get; set;}
        
        ILocalizedString Name { get; set;}
        
        ITypedMoney Money { get; set;}
        
        ITaxedItemPrice TaxedPrice { get; set;}
        
        ITypedMoney TotalPrice { get; set;}
        
        string Slug { get; set;}
        
        long Quantity { get; set;}
        
        List<IItemState> State { get; set;}
        
        ITaxCategoryReference TaxCategory { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        List<IDiscountedLineItemPriceForQuantity> DiscountedPricePerQuantity { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IItemShippingDetails ShippingDetails { get; set;}
    }
}
