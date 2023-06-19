using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddLocalizedEnumValueChange : IAddLocalizedEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedEnumValue NextValue { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public AddLocalizedEnumValueChange()
        {
            this.Type = "AddLocalizedEnumValueChange";
        }
    }
}
