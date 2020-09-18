using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomShippingMethod")]
    public class StagedOrderSetCustomShippingMethodAction : StagedOrderUpdateAction
    {
        public string ShippingMethodName { get; set;}
        
        public ShippingRateDraft ShippingRate { get; set;}
        
        public TaxCategoryResourceIdentifier TaxCategory { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
