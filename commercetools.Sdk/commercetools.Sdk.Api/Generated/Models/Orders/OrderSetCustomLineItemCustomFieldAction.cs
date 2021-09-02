using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class OrderSetCustomLineItemCustomFieldAction : IOrderSetCustomLineItemCustomFieldAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetCustomLineItemCustomFieldAction()
        {
            this.Action = "setCustomLineItemCustomField";
        }
    }
}
