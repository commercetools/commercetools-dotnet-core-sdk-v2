using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetCustomFieldAction))]
    public partial interface IStandalonePriceSetCustomFieldAction : IStandalonePriceUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
