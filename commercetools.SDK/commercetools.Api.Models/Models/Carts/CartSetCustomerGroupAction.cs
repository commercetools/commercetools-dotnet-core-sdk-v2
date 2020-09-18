using commercetools.Api.Models.Carts;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomerGroup")]
    public class CartSetCustomerGroupAction : CartUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
