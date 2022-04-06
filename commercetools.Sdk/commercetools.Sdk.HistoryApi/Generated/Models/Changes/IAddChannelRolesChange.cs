using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange))]
    public partial interface IAddChannelRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IChannelRole> PreviousValue { get; set; }

        List<IChannelRole> NextValue { get; set; }
    }
}
