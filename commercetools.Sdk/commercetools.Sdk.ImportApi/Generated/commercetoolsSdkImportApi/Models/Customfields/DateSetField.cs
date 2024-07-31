using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateSetField : IDateSetField
    {
        public string Type { get; set; }

        public IList<Date> Value { get; set; }

        public IEnumerable<Date> ValueEnumerable { set => Value = value.ToList(); }
        public DateSetField()
        {
            this.Type = "DateSet";
        }
    }
}
