using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomerEmail")]
    public partial class StagedOrderSetCustomerEmailAction : StagedOrderUpdateAction
    {
        public string Email { get; set;}
        public StagedOrderSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
