using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class EnumSetField : IEnumSetField
    {
        public string Type { get; set; }

        public List<string> Value { get; set; }
        public EnumSetField()
        {
            this.Type = "EnumSet";
        }
    }
}
