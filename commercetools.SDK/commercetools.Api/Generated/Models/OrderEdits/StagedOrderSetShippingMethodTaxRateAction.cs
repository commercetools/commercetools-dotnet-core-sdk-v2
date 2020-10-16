using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setShippingMethodTaxRate")]
    public partial class StagedOrderSetShippingMethodTaxRateAction : StagedOrderUpdateAction
    {
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetShippingMethodTaxRateAction()
        { 
           this.Action = "setShippingMethodTaxRate";
        }
    }
}
