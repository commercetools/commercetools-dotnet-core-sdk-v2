using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{

    public partial class ShippingRateDraft : IShippingRateDraft
    {
        public IMoney Price { get; set; }

        public IMoney FreeAbove { get; set; }

        public List<IShippingRatePriceTier> Tiers { get; set; }
    }
}
