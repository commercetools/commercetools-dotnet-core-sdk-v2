using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetShippingCustomFieldAction : ICartSetShippingCustomFieldAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetShippingCustomFieldAction()
        {
            this.Action = "setShippingCustomField";
        }
    }
}
