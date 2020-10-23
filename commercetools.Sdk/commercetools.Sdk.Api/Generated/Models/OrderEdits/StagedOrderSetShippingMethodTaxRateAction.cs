using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class StagedOrderSetShippingMethodTaxRateAction : IStagedOrderSetShippingMethodTaxRateAction
    {
        public string Action { get; set;}
        
        public IExternalTaxRateDraft ExternalTaxRate { get; set;}
        public StagedOrderSetShippingMethodTaxRateAction()
        { 
           this.Action = "setShippingMethodTaxRate";
        }
    }
}
