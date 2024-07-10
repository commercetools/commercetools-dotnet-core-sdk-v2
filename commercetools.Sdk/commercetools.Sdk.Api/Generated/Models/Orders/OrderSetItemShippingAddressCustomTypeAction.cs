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

    public partial class OrderSetItemShippingAddressCustomTypeAction : IOrderSetItemShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public OrderSetItemShippingAddressCustomTypeAction()
        {
            this.Action = "setItemShippingAddressCustomType";
        }
    }
}
