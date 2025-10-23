using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetTransitionsChange : ISetTransitionsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReference> PreviousValue { get; set; }

        public IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IReference> NextValue { get; set; }

        public IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IList<IReference> AddedItems { get; set; }

        public IEnumerable<IReference> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IReference> RemovedItems { get; set; }

        public IEnumerable<IReference> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }
        public SetTransitionsChange()
        {
            this.Type = "SetTransitionsChange";
        }
    }
}
