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


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IShippingInfoImportDraft 
    {
        string ShippingMethodName { get; set;}
        
        IMoney Price { get; set;}
        
        IShippingRateDraft ShippingRate { get; set;}
        
        ITaxRate TaxRate { get; set;}
        
        ITaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        IShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        List<IDelivery> Deliveries { get; set;}
        
        IDiscountedLineItemPriceDraft DiscountedPrice { get; set;}
        
        string ShippingMethodState { get; set;}
        
        ShippingMethodState ShippingMethodStateAsEnum { get; }
    }
}
