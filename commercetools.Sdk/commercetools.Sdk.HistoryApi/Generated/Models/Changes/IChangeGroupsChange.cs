using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


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
