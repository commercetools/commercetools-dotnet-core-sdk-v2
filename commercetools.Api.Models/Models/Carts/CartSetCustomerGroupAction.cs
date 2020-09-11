using commercetools.Api.Models.Carts;
using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetCustomerGroupAction : CartUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
