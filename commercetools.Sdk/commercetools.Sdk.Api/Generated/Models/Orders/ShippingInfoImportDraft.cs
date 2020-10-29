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


namespace commercetools.Api.Models.Orders
{
    public partial class ShippingInfoImportDraft : IShippingInfoImportDraft
    {
        public string ShippingMethodName { get; set;}
        
        public IMoney Price { get; set;}
        
        public IShippingRateDraft ShippingRate { get; set;}
        
        public ITaxRate TaxRate { get; set;}
        
        public ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public List<IDelivery> Deliveries { get; set;}
        
        public IDiscountedLineItemPriceDraft DiscountedPrice { get; set;}
        
        public string ShippingMethodState { get; set;}
        
        [JsonIgnore]
        public ShippingMethodState ShippingMethodStateAsEnum => this.ShippingMethodState.GetEnum<ShippingMethodState>();
    }
}
