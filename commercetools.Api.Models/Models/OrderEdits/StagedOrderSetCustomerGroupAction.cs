using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetCustomerGroupAction : StagedOrderUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
