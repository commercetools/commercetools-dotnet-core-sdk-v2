using commercetools.Sdk.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyCartRemoveItemShippingAddressAction : IMyCartRemoveItemShippingAddressAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }
        public MyCartRemoveItemShippingAddressAction()
        {
            this.Action = "removeItemShippingAddress";
        }
    }
}
