using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetChannelRolesChange : ISetChannelRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IChannelRoleEnum> PreviousValue { get; set; }

        public IEnumerable<IChannelRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IChannelRoleEnum> NextValue { get; set; }

        public IEnumerable<IChannelRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }

        public IList<IChannelRoleEnum> AddedItems { get; set; }

        public IEnumerable<IChannelRoleEnum> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<IChannelRoleEnum> RemovedItems { get; set; }

        public IEnumerable<IChannelRoleEnum> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }
        public SetChannelRolesChange()
        {
            this.Type = "SetChannelRolesChange";
        }
    }
}
