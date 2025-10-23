using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class ChangeGroupsChange : IChangeGroupsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<string> PreviousValue { get; set; }

        public IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<string> NextValue { get; set; }

        public IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IList<string> AddedItems { get; set; }

        public IEnumerable<string> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<string> RemovedItems { get; set; }

        public IEnumerable<string> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }
        public ChangeGroupsChange()
        {
            this.Type = "ChangeGroupsChange";
        }
    }
}
