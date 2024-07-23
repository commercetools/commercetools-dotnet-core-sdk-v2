using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetValidFromAndUntilAction))]
    public partial interface IStandalonePriceSetValidFromAndUntilAction : IStandalonePriceUpdateAction
    {
        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

    }
}
