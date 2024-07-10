using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetShippingCustomFieldAction : IStagedOrderSetShippingCustomFieldAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public StagedOrderSetShippingCustomFieldAction()
        {
            this.Action = "setShippingCustomField";
        }
    }
}
