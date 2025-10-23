using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnItemLineItemCustomFieldChange))]
    public partial interface ISetReturnItemLineItemCustomFieldChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string Variant { get; set; }

        ILocalizedString LineItem { get; set; }

        string LineItemId { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
