using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingAddressAction : IStagedOrderSetShippingAddressAction
    {
        public string Action { get; set;}
        
        public IBaseAddress Address { get; set;}
        public StagedOrderSetShippingAddressAction()
        { 
           this.Action = "setShippingAddress";
        }
    }
}
