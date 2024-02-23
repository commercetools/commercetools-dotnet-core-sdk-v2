using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveStateRolesChange))]
    public partial interface IRemoveStateRolesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IStateRoleEnum> PreviousValue { get; set; }
        IEnumerable<IStateRoleEnum> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IStateRoleEnum> NextValue { get; set; }
        IEnumerable<IStateRoleEnum> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
