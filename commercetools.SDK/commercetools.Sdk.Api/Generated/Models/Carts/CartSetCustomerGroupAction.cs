using commercetools.Api.Models.Carts;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomerGroup")]
    public partial class CartSetCustomerGroupAction : CartUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public CartSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
