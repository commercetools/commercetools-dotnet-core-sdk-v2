using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setCustomerId")]
    public partial class OrderSetCustomerIdAction : OrderUpdateAction
    {
        public string CustomerId { get; set;}
        public OrderSetCustomerIdAction()
        { 
           this.Action = "setCustomerId";
        }
    }
}
