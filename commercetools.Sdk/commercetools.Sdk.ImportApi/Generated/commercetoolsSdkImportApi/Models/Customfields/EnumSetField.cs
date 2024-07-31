using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class EnumSetField : IEnumSetField
    {
        public string Type { get; set; }

        public IList<string> Value { get; set; }

        public IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }
        public EnumSetField()
        {
            this.Type = "EnumSet";
        }
    }
}
