using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class BooleanSetField : IBooleanSetField
    {
        public string Type { get; set; }

        public IList<bool> Value { get; set; }

        public IEnumerable<bool> ValueEnumerable { set => Value = value.ToList(); }
        public BooleanSetField()
        {
            this.Type = "BooleanSet";
        }
    }
}
