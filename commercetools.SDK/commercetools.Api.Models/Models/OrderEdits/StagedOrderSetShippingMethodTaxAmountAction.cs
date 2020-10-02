using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setShippingMethodTaxAmount")]
    public partial class StagedOrderSetShippingMethodTaxAmountAction : StagedOrderUpdateAction
    {
        public ExternalTaxAmountDraft ExternalTaxAmount { get; set;}
        public StagedOrderSetShippingMethodTaxAmountAction()
        { 
           this.Action = "setShippingMethodTaxAmount";
        }
    }
}
