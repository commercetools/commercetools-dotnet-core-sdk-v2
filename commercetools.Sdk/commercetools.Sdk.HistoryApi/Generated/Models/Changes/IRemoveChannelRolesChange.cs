using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveChannelRolesChange))]
    public partial interface IRemoveChannelRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IChannelRoleEnum> PreviousValue { get; set; }
        IEnumerable<IChannelRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IChannelRoleEnum> NextValue { get; set; }
        IEnumerable<IChannelRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
