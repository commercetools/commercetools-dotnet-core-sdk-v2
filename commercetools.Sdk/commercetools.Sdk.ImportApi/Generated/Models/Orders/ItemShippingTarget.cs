using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public long Quantity { get; set; }
    }
}
