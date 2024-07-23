using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange))]
    public partial interface IRemoveLocalizedEnumValuesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedEnumValue PreviousValue { get; set; }

        string AttributeName { get; set; }

    }
}
