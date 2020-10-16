using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setShippingMethod")]
    public partial class StagedOrderSetShippingMethodAction : StagedOrderUpdateAction
    {
        public ShippingMethodResourceIdentifier ShippingMethod { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetShippingMethodAction()
        { 
           this.Action = "setShippingMethod";
        }
    }
}
