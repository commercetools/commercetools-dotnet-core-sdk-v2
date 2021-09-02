using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomerIdAction : IOrderSetCustomerIdAction
    {
        public string Action { get; set; }

        public string CustomerId { get; set; }
        public OrderSetCustomerIdAction()
        {
            this.Action = "setCustomerId";
        }
    }
}
