using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomerGroupAction : IStagedOrderSetCustomerGroupAction
    {
        public string Action { get; set;}
        
        public ICustomerGroupResourceIdentifier CustomerGroup { get; set;}
        public StagedOrderSetCustomerGroupAction()
        { 
           this.Action = "setCustomerGroup";
        }
    }
}
