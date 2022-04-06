namespace commercetools.Sdk.ImportApi.Models.Customfields
{
    public partial class LocalizedEnumField : ILocalizedEnumField
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public LocalizedEnumField()
        {
            this.Type = "LocalizedEnum";
        }
    }
}
