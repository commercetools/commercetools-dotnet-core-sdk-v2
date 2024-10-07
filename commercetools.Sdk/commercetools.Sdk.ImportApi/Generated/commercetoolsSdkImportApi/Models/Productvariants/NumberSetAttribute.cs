using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class NumberSetAttribute : INumberSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<decimal> Value { get; set; }

        public IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }
        public NumberSetAttribute()
        {
            this.Type = "number-set";
        }
    }
}
