using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddPlainEnumValueChange : IAddPlainEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributePlainEnumValue NextValue { get; set; }

        public string AttributeName { get; set; }
        public AddPlainEnumValueChange()
        {
            this.Type = "AddPlainEnumValueChange";
        }
    }
}
