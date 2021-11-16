using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.TaxCategories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CustomLineItem))]
    public partial interface ICustomLineItem 
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
