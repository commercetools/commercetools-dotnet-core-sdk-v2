using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.CartClassificationTier))]
    public partial interface ICartClassificationTier : IShippingRatePriceTier
    {
        string Value { get; set; }

        IMoney Price { get; set; }

        List<IShippingRatePriceTier> Tiers { get; set; }

        bool? IsMatching { get; set; }
    }
}
