using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveStateRolesChange))]
    public partial interface IRemoveStateRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IStateRole> PreviousValue { get; set; }

        List<IStateRole> NextValue { get; set; }
    }
}
