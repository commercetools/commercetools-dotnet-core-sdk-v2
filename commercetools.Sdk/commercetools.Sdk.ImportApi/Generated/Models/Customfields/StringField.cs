namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class StringField : IStringField
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public StringField()
        {
            this.Type = "String";
        }
    }
}
