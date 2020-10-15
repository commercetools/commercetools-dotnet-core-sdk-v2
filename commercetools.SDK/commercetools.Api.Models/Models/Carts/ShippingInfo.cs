using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class ShippingInfo 
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
        
        public string ShippingMethodState { get; set;}
        
        [JsonIgnore]
        public ShippingMethodState ShippingMethodStateAsEnum => this.ShippingMethodState.GetEnum<ShippingMethodState>();
    }
}
