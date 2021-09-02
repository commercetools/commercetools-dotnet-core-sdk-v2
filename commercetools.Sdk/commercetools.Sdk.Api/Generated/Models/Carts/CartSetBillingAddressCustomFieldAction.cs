using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetBillingAddressCustomFieldAction : ICartSetBillingAddressCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CartSetBillingAddressCustomFieldAction()
        {
            this.Action = "setBillingAddressCustomField";
        }
    }
}
