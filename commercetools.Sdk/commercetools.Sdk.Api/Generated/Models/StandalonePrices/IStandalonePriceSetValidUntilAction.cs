using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidUntilAction))]
    public partial interface IStandalonePriceSetValidUntilAction : IStandalonePriceUpdateAction
    {
        DateTime? ValidUntil { get; set; }

    }
}
