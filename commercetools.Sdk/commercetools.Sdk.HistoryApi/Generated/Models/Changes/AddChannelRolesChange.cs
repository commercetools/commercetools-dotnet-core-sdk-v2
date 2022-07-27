using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddChannelRolesChange : IAddChannelRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IChannelRole> PreviousValue { get; set; }

        public List<IChannelRole> NextValue { get; set; }
        public AddChannelRolesChange()
        {
            this.Type = "AddChannelRolesChange";
        }
    }
}
