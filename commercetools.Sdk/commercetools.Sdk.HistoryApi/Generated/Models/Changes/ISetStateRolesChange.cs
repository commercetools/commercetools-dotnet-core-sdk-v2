using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange))]
    public partial interface ISetStateRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IStateRole> PreviousValue { get; set; }

        List<IStateRole> NextValue { get; set; }

    }
}
