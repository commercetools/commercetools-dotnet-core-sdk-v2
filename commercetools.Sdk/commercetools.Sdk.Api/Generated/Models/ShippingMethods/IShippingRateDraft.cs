using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingRateDraft))]
    public partial interface IShippingRateDraft
    {
        IMoney Price { get; set; }

        IMoney FreeAbove { get; set; }

        List<IShippingRatePriceTier> Tiers { get; set; }

    }
}
