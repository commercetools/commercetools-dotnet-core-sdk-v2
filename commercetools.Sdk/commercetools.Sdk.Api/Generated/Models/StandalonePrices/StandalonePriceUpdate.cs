using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    public partial class StandalonePriceUpdate : IStandalonePriceUpdate
    {
        public long Version { get; set; }

        public List<IStandalonePriceUpdateAction> Actions { get; set; }
    }
}
