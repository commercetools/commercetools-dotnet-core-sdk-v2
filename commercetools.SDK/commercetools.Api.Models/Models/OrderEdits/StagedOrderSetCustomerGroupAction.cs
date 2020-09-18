using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomerGroup")]
    public class StagedOrderSetCustomerGroupAction : StagedOrderUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
    }
}
