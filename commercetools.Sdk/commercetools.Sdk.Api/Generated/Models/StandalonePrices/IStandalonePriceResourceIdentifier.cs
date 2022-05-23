using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceResourceIdentifier))]
    public partial interface IStandalonePriceResourceIdentifier : IResourceIdentifier
    {
    }
}
