using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAction))]
    public partial interface IStandalonePriceSetValidFromAction : IStandalonePriceUpdateAction
    {
        DateTime? ValidFrom { get; set; }

    }
}
