using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveChannelRolesChange))]
    public partial interface IRemoveChannelRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IChannelRole> PreviousValue { get; set; }

        List<IChannelRole> NextValue { get; set; }
    }
}
