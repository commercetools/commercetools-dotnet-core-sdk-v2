using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetInheritedAssociatesChange : ISetInheritedAssociatesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IInheritedAssociate> AddedItems { get; set; }

        public IEnumerable<IInheritedAssociate> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IInheritedAssociate> RemovedItems { get; set; }

        public IEnumerable<IInheritedAssociate> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<IInheritedAssociate> PreviousValue { get; set; }

        public IEnumerable<IInheritedAssociate> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IInheritedAssociate> NextValue { get; set; }

        public IEnumerable<IInheritedAssociate> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetInheritedAssociatesChange()
        {
            this.Type = "SetInheritedAssociatesChange";
        }
    }
}
