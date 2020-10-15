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


namespace commercetools.Api.Models.Orders
{
    public partial class ShippingInfoImportDraft 
    {
        public string ShippingMethodName { get; set;}
        
        public Money Price { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
        
        public TaxRate TaxRate { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public List<Delivery> Deliveries { get; set;}
        
        public DiscountedLineItemPriceDraft DiscountedPrice { get; set;}
        
        public string ShippingMethodState { get; set;}
        
        [JsonIgnore]
        public ShippingMethodState ShippingMethodStateAsEnum => this.ShippingMethodState.GetEnum<ShippingMethodState>();
    }
}
