using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set; }

        public IMoney FreeAbove { get; set; }

        public List<IShippingRatePriceTier> Tiers { get; set; }
    }
}
