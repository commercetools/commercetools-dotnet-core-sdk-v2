using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveChannelRolesChange : IRemoveChannelRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IChannelRoleEnum> PreviousValue { get; set; }

        public IEnumerable<IChannelRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<IChannelRoleEnum> NextValue { get; set; }

        public IEnumerable<IChannelRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }
        public RemoveChannelRolesChange()
        {
            this.Type = "RemoveChannelRolesChange";
        }
    }
}
