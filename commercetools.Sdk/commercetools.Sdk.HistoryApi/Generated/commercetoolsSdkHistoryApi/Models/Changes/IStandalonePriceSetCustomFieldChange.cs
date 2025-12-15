using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.StandalonePriceSetCustomFieldChange))]
    public partial interface IStandalonePriceSetCustomFieldChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
