using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class StringSetField : IStringSetField
    {
        public string Type { get; set; }

        public IList<string> Value { get; set; }

        public IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }
        public StringSetField()
        {
            this.Type = "StringSet";
        }
    }
}
