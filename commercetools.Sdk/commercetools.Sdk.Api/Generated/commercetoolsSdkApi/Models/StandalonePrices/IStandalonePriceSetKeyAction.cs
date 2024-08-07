using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceSetKeyAction))]
    public partial interface IStandalonePriceSetKeyAction : IStandalonePriceUpdateAction
    {
        string Key { get; set; }

    }
}
