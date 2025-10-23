using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange))]
    public partial interface IRemoveEnumValuesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAttributePlainEnumValue PreviousValue { get; set; }

        string AttributeName { get; set; }

    }
}
