using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingRate))]
    public partial interface IShippingRate
    {
        ITypedMoney Price { get; set; }

        ITypedMoney FreeAbove { get; set; }

        bool? IsMatching { get; set; }

        List<IShippingRatePriceTier> Tiers { get; set; }

    }
}
