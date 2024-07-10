using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetParcelCustomFieldAction : IOrderSetParcelCustomFieldAction
    {
        public string Action { get; set; }

        public string ParcelId { get; set; }

        public string ParcelKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public OrderSetParcelCustomFieldAction()
        {
            this.Action = "setParcelCustomField";
        }
    }
}
