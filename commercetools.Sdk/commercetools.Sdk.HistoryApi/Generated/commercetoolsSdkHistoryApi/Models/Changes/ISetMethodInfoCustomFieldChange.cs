using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetMethodInfoCustomFieldChange))]
    public partial interface ISetMethodInfoCustomFieldChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
