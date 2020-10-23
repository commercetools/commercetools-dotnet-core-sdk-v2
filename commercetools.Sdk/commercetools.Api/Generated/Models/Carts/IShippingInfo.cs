using commercetools.Api.Generated.Models.Carts;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.ShippingMethods;
using commercetools.Api.Generated.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface IShippingInfo 
    {
        string ShippingMethodName { get; set;}
        
        ITypedMoney Price { get; set;}
        
        IShippingRate ShippingRate { get; set;}
        
        ITaxedItemPrice TaxedPrice { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        ITaxCategoryReference TaxCategory { get; set;}
        
        IShippingMethodReference ShippingMethod { get; set;}
        
        List<IDelivery> Deliveries { get; set;}
        
        IDiscountedLineItemPrice DiscountedPrice { get; set;}
        
        string ShippingMethodState { get; set;}
        
        ShippingMethodState ShippingMethodStateAsEnum { get; }
    }
}
