using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetCustomerGroupAction : ICartSetCustomerGroupAction
    {
        public string Action { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }
        public CartSetCustomerGroupAction()
        {
            this.Action = "setCustomerGroup";
        }
    }
}
