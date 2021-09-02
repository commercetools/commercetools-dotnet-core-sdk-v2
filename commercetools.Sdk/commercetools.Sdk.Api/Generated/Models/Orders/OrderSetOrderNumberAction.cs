using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetOrderNumberAction : IOrderSetOrderNumberAction
    {
        public string Action { get; set; }

        public string OrderNumber { get; set; }
        public OrderSetOrderNumberAction()
        {
            this.Action = "setOrderNumber";
        }
    }
}
