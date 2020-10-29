using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomerEmailAction : IStagedOrderSetCustomerEmailAction
    {
        public string Action { get; set;}
        
        public string Email { get; set;}
        public StagedOrderSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
