using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class EnumSetAttribute : IEnumSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<string> Value { get; set; }
        public EnumSetAttribute()
        {
            this.Type = "enum-set";
        }
    }
}
