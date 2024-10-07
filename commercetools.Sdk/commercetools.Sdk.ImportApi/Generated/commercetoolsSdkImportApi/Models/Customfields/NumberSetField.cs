using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class NumberSetField : INumberSetField
    {
        public string Type { get; set; }

        public IList<decimal> Value { get; set; }

        public IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }
        public NumberSetField()
        {
            this.Type = "NumberSet";
        }
    }
}
