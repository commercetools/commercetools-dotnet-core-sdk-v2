using commercetools.Sdk.HistoryApi.Models.Common;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class AddEnumValueChange : IAddEnumValueChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomFieldEnumValue NextValue { get; set; }

        public string FieldName { get; set; }

        public string AttributeName { get; set; }
        public AddEnumValueChange()
        {
            this.Type = "AddEnumValueChange";
        }
    }
}
