using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetAssociatesChange : ISetAssociatesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IAssociate> AddedItems { get; set; }

        public IEnumerable<IAssociate> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IAssociate> RemovedItems { get; set; }

        public IEnumerable<IAssociate> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<IAssociate> PreviousValue { get; set; }

        public IEnumerable<IAssociate> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IAssociate> NextValue { get; set; }

        public IEnumerable<IAssociate> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetAssociatesChange()
        {
            this.Type = "SetAssociatesChange";
        }
    }
}
