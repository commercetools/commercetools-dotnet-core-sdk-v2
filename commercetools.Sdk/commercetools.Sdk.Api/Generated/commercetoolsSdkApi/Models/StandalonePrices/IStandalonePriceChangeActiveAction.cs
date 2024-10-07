using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeActiveAction))]
    public partial interface IStandalonePriceChangeActiveAction : IStandalonePriceUpdateAction
    {
        bool Active { get; set; }

    }
}
