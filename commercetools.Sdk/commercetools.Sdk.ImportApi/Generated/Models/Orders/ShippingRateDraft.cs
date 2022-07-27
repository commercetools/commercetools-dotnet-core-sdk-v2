using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set; }

        public IMoney FreeAbove { get; set; }

        public List<IShippingRatePriceTier> Tiers { get; set; }
    }
}
