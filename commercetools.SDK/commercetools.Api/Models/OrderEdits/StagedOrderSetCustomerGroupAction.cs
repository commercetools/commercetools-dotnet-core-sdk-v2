using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomerGroup")]
    public partial class StagedOrderSetCustomerGroupAction : StagedOrderUpdateAction
    {
        public CustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public StagedOrderSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
