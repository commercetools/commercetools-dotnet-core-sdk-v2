using commercetools.Sdk.HistoryApi.Models.ChangeValues;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddPlainEnumValueChange : IAddPlainEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IEnumValue NextValue { get; set; }

        public string AttributeName { get; set; }
        public AddPlainEnumValueChange()
        {
            this.Type = "AddPlainEnumValueChange";
        }
    }
}
