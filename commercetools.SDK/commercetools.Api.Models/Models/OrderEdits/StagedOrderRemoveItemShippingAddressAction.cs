using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeItemShippingAddress")]
    public partial class StagedOrderRemoveItemShippingAddressAction : StagedOrderUpdateAction
    {
        public string AddressKey { get; set;}
        public StagedOrderRemoveItemShippingAddressAction()
        { 
           this.Action = "removeItemShippingAddress";
        }
    }
}
