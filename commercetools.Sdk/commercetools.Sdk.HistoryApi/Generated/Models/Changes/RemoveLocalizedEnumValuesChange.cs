using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveLocalizedEnumValuesChange : IRemoveLocalizedEnumValuesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string AttributeName { get; set; }

        public ILocalizedEnumValue PreviousValue { get; set; }
        public RemoveLocalizedEnumValuesChange()
        {
            this.Type = "RemoveLocalizedEnumValuesChange";
        }
    }
}
