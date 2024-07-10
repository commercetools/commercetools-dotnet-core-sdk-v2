using commercetools.Sdk.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomerEmailAction : ICartSetCustomerEmailAction
    {
        public string Action { get; set; }

        public string Email { get; set; }
        public CartSetCustomerEmailAction()
        {
            this.Action = "setCustomerEmail";
        }
    }
}
