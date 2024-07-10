using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderRemoveItemShippingAddressAction : IStagedOrderRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public StagedOrderRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
