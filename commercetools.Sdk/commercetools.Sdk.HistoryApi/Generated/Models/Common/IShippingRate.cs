using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingRate))]
    public partial interface IShippingRate
    {
        IMoney Price { get; set; }

        IMoney FreeAbove { get; set; }

        bool IsMatching { get; set; }

        List<IShippingRatePriceTier> Tiers { get; set; }
    }
}
