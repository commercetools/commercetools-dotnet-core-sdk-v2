using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStateRolesChange))]
    public partial interface ISetStateRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IStateRole> PreviousValue { get; set; }
        IEnumerable<IStateRole> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IStateRole> NextValue { get; set; }
        IEnumerable<IStateRole> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
