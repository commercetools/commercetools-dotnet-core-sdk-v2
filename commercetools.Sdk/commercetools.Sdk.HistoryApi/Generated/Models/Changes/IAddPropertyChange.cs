using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddPropertyChange))]
    public partial interface IAddPropertyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string Path { get; set; }

        Object NextValue { get; set; }

    }
}
