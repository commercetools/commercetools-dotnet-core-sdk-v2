using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddEnumValueChange))]
    public partial interface IAddEnumValueChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IEnumValue NextValue { get; set; }

        string FieldName { get; set; }

    }
}
