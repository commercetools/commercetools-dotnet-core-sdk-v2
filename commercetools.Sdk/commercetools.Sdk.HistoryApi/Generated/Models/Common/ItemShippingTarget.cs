using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public int Quantity { get; set; }
    }
}
