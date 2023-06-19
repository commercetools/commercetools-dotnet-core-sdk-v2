using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShippingRate))]
    public partial interface IShippingRate
    {
        IMoney Price { get; set; }

        IMoney FreeAbove { get; set; }

        bool IsMatching { get; set; }

        IList<IShippingRatePriceTier> Tiers { get; set; }
        IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


    }
}
