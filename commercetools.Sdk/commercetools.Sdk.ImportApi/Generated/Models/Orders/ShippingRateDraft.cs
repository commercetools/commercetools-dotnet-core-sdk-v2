using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set; }

        public IMoney FreeAbove { get; set; }

        public IList<IShippingRatePriceTier> Tiers { get; set; }
        public IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

    }
}
