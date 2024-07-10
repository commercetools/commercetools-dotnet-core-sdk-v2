using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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

        public SetChannelRolesChange()
        {
            this.Type = "SetChannelRolesChange";
        }
    }
}
