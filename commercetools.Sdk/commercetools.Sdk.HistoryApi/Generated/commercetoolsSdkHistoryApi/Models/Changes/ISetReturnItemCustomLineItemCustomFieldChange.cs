using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReturnItemCustomLineItemCustomFieldChange))]
    public partial interface ISetReturnItemCustomLineItemCustomFieldChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

    }
}
