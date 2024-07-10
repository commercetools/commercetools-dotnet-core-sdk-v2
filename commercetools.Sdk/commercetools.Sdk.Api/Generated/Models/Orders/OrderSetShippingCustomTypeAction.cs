using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetShippingCustomTypeAction : IOrderSetShippingCustomTypeAction
    {
        public string Action { get; set; }

        public string ShippingKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetShippingCustomTypeAction()
        {
            this.Action = "setShippingCustomType";
        }
    }
}
