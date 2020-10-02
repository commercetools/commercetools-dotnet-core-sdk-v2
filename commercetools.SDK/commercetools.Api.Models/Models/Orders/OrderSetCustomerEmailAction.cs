using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomerEmail")]
    public partial class OrderSetCustomerEmailAction : OrderUpdateAction
    {
        public string Email { get; set;}
        public OrderSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
