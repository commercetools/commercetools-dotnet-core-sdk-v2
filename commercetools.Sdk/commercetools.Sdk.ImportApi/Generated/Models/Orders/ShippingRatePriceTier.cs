using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public abstract partial class ShippingRatePriceTier : IShippingRatePriceTier
    {
        public IShippingRateTierType Type { get; set;}
    }
}
