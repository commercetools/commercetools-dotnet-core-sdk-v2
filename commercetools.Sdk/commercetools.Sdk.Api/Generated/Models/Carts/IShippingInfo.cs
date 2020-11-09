using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ShippingInfo))]
    public partial interface IShippingInfo 
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
