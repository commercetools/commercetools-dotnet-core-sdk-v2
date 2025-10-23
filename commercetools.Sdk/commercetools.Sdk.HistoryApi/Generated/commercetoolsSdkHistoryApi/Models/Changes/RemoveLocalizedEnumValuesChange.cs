using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class RemoveLocalizedEnumValuesChange : IRemoveLocalizedEnumValuesChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeLocalizedEnumValue PreviousValue { get; set; }

        public string AttributeName { get; set; }
        public RemoveLocalizedEnumValuesChange()
        {
            this.Type = "RemoveLocalizedEnumValuesChange";
        }
    }
}
