using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetStoresChange))]
    public partial interface ISetStoresChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IReference> PreviousValue { get; set; }
        IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IReference> NextValue { get; set; }
        IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
