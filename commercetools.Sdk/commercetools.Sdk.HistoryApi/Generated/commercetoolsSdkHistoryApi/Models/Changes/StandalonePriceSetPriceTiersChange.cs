using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class StandalonePriceSetPriceTiersChange : IStandalonePriceSetPriceTiersChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IPriceTier> AddedItems { get; set; }

        public IEnumerable<IPriceTier> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IPriceTier> RemovedItems { get; set; }

        public IEnumerable<IPriceTier> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<IPriceTier> PreviousValue { get; set; }

        public IEnumerable<IPriceTier> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IPriceTier> NextValue { get; set; }

        public IEnumerable<IPriceTier> NextValueEnumerable { set => NextValue = value.ToList(); }
        public StandalonePriceSetPriceTiersChange()
        {
            this.Type = "StandalonePriceSetPriceTiersChange";
        }
    }
}
