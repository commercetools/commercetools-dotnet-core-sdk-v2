using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetInheritedStoresChange : ISetInheritedStoresChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IKeyReference> AddedItems { get; set; }

        public IEnumerable<IKeyReference> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IKeyReference> RemovedItems { get; set; }

        public IEnumerable<IKeyReference> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<IKeyReference> PreviousValue { get; set; }

        public IEnumerable<IKeyReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IKeyReference> NextValue { get; set; }

        public IEnumerable<IKeyReference> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetInheritedStoresChange()
        {
            this.Type = "SetInheritedStoresChange";
        }
    }
}
