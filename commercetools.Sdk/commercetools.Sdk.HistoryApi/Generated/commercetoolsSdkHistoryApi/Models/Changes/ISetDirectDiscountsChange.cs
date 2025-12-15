using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDirectDiscountsChange))]
    public partial interface ISetDirectDiscountsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IDirectDiscount> AddedItems { get; set; }

        IEnumerable<IDirectDiscount> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IDirectDiscount> RemovedItems { get; set; }

        IEnumerable<IDirectDiscount> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<IDirectDiscount> PreviousValue { get; set; }

        IEnumerable<IDirectDiscount> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IDirectDiscount> NextValue { get; set; }

        IEnumerable<IDirectDiscount> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
