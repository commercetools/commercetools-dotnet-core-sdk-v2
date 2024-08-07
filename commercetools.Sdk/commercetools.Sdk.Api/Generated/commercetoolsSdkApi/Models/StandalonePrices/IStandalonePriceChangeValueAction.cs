using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction))]
    public partial interface IStandalonePriceChangeValueAction : IStandalonePriceUpdateAction
    {
        IMoney Value { get; set; }

        bool? Staged { get; set; }

    }
}
