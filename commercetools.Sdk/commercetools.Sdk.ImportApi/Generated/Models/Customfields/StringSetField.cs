using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class StringSetField : IStringSetField
    {
        public string Type { get; set; }

        public List<string> Value { get; set; }
        public StringSetField()
        {
            this.Type = "StringSet";
        }
    }
}
