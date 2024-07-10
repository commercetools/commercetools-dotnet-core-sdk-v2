using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddEnumValueChange : IAddEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IEnumValue NextValue { get; set; }

        public string FieldName { get; set; }
        public AddEnumValueChange()
        {
            this.Type = "AddEnumValueChange";
        }
    }
}
