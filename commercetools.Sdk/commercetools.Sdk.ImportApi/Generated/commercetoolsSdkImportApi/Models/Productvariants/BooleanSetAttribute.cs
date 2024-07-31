using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class BooleanSetAttribute : IBooleanSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<bool> Value { get; set; }

        public IEnumerable<bool> ValueEnumerable { set => Value = value.ToList(); }
        public BooleanSetAttribute()
        {
            this.Type = "boolean-set";
        }
    }
}
