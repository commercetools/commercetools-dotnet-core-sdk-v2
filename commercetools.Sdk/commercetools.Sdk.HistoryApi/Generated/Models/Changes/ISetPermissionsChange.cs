using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

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
