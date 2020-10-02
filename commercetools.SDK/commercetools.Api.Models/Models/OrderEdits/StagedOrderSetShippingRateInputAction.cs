using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setShippingRateInput")]
    public partial class StagedOrderSetShippingRateInputAction : StagedOrderUpdateAction
    {
        public ShippingRateInputDraft ShippingRateInput { get; set;}
        public StagedOrderSetShippingRateInputAction()
        { 
           this.Action = "setShippingRateInput";
        }
    }
}
