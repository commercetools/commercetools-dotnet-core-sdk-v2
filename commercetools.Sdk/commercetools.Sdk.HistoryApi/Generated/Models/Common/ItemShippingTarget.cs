using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class ItemShippingTarget : IItemShippingTarget
    {
        public string AddressKey { get; set; }

        public int Quantity { get; set; }
    }
}
