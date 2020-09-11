using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class ShippingInfo 
    {
        public string ShippingMethodName { get; set;}
        
        public TypedMoney Price { get; set;}
        
        public ShippingRate ShippingRate { get; set;}
        
        public TaxedItemPrice TaxedPrice { get; set;}
        
        public TaxRate TaxRate { get; set;}
        
        public TaxCategoryReference TaxCategory { get; set;}
        
        public ShippingMethodReference ShippingMethod { get; set;}
        
        public List<Delivery> Deliveries { get; set;}
        
        public DiscountedLineItemPrice DiscountedPrice { get; set;}
        
        public ShippingMethodState ShippingMethodState { get; set;}
    }
}
