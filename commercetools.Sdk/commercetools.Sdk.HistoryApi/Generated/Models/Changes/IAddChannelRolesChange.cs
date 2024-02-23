using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddChannelRolesChange))]
    public partial interface IAddChannelRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IChannelRoleEnum> PreviousValue { get; set; }
        IEnumerable<IChannelRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IChannelRoleEnum> NextValue { get; set; }
        IEnumerable<IChannelRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
