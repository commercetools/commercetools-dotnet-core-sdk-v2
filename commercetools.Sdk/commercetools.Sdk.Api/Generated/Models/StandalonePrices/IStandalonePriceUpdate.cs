using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StandalonePrices.StandalonePriceUpdate))]
    public partial interface IStandalonePriceUpdate
    {
        long Version { get; set; }

        List<IStandalonePriceUpdateAction> Actions { get; set; }
    }
}
