using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddToCategoryChange))]
    public partial interface IAddToCategoryChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IReference Category { get; set; }

        List<IReference> PreviousValue { get; set; }

        List<IReference> NextValue { get; set; }

    }
}
