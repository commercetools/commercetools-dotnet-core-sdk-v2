using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetChannelRolesChange))]
    public partial interface ISetChannelRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IChannelRole> PreviousValue { get; set; }
        IEnumerable<IChannelRole> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IChannelRole> NextValue { get; set; }
        IEnumerable<IChannelRole> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
