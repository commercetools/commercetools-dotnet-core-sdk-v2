using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange))]
    public partial interface ISetOrderLineItemCustomFieldChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CustomTypeId { get; set; }

        string Name { get; set; }

        string Variant { get; set; }

        ILocalizedString LineItem { get; set; }

        Object NextValue { get; set; }

        Object PreviousValue { get; set; }
    }
}
