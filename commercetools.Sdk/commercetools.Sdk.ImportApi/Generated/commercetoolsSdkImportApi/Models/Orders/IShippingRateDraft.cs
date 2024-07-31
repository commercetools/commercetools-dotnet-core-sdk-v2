using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.ShippingRateDraft))]
    public partial interface IShippingRateDraft
    {
        IMoney Price { get; set; }

        IMoney FreeAbove { get; set; }

        IList<IShippingRatePriceTier> Tiers { get; set; }

        IEnumerable<IShippingRatePriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

    }
}
