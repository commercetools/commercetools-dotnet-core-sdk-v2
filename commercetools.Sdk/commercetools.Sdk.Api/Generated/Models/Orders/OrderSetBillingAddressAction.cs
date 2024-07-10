using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetBillingAddressAction : IOrderSetBillingAddressAction
    {
        public string Action { get; set; }

        public IBaseAddress Address { get; set; }
        public OrderSetBillingAddressAction()
        {
            this.Action = "setBillingAddress";
        }
    }
}
