using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.RemoveEnumValuesChange))]
    public partial interface IRemoveEnumValuesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IEnumValue PreviousValue { get; set; }

        string AttributeName { get; set; }

    }
}
