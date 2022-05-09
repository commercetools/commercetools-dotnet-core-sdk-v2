using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceChangeValueAction))]
    public partial interface IStandalonePriceChangeValueAction : IStandalonePriceUpdateAction
    {
        IMoney Value { get; set; }
    }
}
