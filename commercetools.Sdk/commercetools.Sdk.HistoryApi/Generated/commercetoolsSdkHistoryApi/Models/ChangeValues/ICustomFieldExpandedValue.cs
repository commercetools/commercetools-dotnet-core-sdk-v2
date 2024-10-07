using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.ChangeValues.CustomFieldExpandedValue))]
    public partial interface ICustomFieldExpandedValue
    {
        string Name { get; set; }

        Object Value { get; set; }

        ILocalizedString Label { get; set; }

    }
}
