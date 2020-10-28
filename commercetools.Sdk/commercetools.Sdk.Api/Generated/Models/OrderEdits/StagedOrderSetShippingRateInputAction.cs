using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingRateInputAction : IStagedOrderSetShippingRateInputAction
    {
        public string Action { get; set;}
        
        public IShippingRateInputDraft ShippingRateInput { get; set;}
        public StagedOrderSetShippingRateInputAction()
        { 
           this.Action = "setShippingRateInput";
        }
    }
}
