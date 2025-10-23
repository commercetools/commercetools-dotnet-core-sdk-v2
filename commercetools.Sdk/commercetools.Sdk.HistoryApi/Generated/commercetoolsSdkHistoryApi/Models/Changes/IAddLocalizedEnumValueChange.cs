using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddLocalizedEnumValueChange))]
    public partial interface IAddLocalizedEnumValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ICustomFieldLocalizedEnumValue NextValue { get; set; }

        string FieldName { get; set; }

        string AttributeName { get; set; }

    }
}
