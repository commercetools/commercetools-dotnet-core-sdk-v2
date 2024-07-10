using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange))]
    public partial interface IChangeGroupsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<string> PreviousValue { get; set; }
        IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<string> NextValue { get; set; }
        IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
