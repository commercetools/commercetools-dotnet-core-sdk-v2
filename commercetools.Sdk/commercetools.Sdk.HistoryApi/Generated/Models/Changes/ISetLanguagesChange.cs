using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLanguagesChange))]
    public partial interface ISetLanguagesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<string> PreviousValue { get; set; }

        List<string> NextValue { get; set; }

    }
}
