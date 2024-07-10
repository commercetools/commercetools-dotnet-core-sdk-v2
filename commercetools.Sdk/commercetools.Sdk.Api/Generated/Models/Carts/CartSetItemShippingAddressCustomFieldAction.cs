using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetItemShippingAddressCustomFieldAction : ICartSetItemShippingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetItemShippingAddressCustomFieldAction()
        {
            this.Action = "setItemShippingAddressCustomField";
        }
    }
}
