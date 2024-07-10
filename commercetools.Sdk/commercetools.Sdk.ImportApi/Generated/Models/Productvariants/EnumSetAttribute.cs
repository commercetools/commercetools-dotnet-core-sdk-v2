using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class EnumSetAttribute : IEnumSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<string> Value { get; set; }
        public IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }

        public EnumSetAttribute()
        {
            this.Type = "enum-set";
        }
    }
}
