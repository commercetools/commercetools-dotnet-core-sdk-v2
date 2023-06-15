using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetValueChange))]
    public partial interface ISetValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
