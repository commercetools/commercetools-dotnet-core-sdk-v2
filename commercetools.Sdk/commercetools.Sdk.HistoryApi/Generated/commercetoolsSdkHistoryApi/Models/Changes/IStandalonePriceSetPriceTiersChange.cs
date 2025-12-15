using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceSetPriceTiersChange))]
    public partial interface IStandalonePriceSetPriceTiersChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IPriceTier> AddedItems { get; set; }

        IEnumerable<IPriceTier> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IPriceTier> RemovedItems { get; set; }

        IEnumerable<IPriceTier> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<IPriceTier> PreviousValue { get; set; }

        IEnumerable<IPriceTier> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IPriceTier> NextValue { get; set; }

        IEnumerable<IPriceTier> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
