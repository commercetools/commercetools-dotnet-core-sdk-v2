using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class LocalizedEnumSetField : ILocalizedEnumSetField
    {
        public string Type { get; set; }

        public List<string> Value { get; set; }
        public LocalizedEnumSetField()
        {
            this.Type = "LocalizedEnumSet";
        }
    }
}
