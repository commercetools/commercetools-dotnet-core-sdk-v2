using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddChannelRolesChange : IAddChannelRolesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IChannelRole> PreviousValue { get; set; }
        public IEnumerable<IChannelRole> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IChannelRole> NextValue { get; set; }
        public IEnumerable<IChannelRole> NextValueEnumerable { set => NextValue = value.ToList(); }

        public AddChannelRolesChange()
        {
            this.Type = "AddChannelRolesChange";
        }
    }
}
