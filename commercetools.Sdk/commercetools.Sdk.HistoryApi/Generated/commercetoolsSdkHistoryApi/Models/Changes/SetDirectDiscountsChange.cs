using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetDirectDiscountsChange : ISetDirectDiscountsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IDirectDiscount> AddedItems { get; set; }

        public IEnumerable<IDirectDiscount> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IDirectDiscount> RemovedItems { get; set; }

        public IEnumerable<IDirectDiscount> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<IDirectDiscount> PreviousValue { get; set; }

        public IEnumerable<IDirectDiscount> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IDirectDiscount> NextValue { get; set; }

        public IEnumerable<IDirectDiscount> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetDirectDiscountsChange()
        {
            this.Type = "SetDirectDiscountsChange";
        }
    }
}
