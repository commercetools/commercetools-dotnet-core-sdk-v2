using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange))]
    public partial interface IRemoveLocalizedEnumValuesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string AttributeName { get; set; }

        ILocalizedEnumValue PreviousValue { get; set; }
    }
}
