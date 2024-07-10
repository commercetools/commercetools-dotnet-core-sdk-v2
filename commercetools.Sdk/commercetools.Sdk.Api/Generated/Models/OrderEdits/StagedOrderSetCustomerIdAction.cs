using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetCustomerIdAction : IStagedOrderSetCustomerIdAction
    {
        public string Action { get; set; }

        public string CustomerId { get; set; }
        public StagedOrderSetCustomerIdAction()
        {
            this.Action = "setCustomerId";
        }
    }
}
