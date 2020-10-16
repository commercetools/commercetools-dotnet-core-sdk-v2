using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomerId")]
    public partial class StagedOrderSetCustomerIdAction : StagedOrderUpdateAction
    {
        public string CustomerId { get; set;}
        public StagedOrderSetCustomerIdAction()
        { 
           this.Action = "setCustomerId";
        }
    }
}
