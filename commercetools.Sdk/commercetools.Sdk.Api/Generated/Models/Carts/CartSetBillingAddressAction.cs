using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetBillingAddressAction : ICartSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public CartSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
