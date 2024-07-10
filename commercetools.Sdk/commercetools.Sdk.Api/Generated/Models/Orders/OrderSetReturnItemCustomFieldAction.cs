using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnItemCustomFieldAction : IOrderSetReturnItemCustomFieldAction
    {
        public string Action { get; set; }

        public string ReturnItemId { get; set; }

        public string ReturnItemKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetReturnItemCustomFieldAction()
        {
            this.Action = "setReturnItemCustomField";
        }
    }
}
