using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveChannelRolesChange : IRemoveChannelRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IChannelRole> PreviousValue { get; set; }

        public List<IChannelRole> NextValue { get; set; }
        public RemoveChannelRolesChange()
        {
            this.Type = "RemoveChannelRolesChange";
        }
    }
}
