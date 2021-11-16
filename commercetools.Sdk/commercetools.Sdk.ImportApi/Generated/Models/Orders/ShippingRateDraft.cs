using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set;}
        
        public IMoney FreeAbove { get; set;}
        
        public List<IShippingRatePriceTier> Tiers { get; set;}
    }
}
