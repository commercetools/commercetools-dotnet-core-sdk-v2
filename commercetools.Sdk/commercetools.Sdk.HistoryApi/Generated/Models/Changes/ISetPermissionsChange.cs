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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPermissionsChange))]
    public partial interface ISetPermissionsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IPermission> PreviousValue { get; set; }
        IEnumerable<IPermission> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IPermission> NextValue { get; set; }
        IEnumerable<IPermission> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
