using System.Collections.Generic;
using System.Linq;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class DateSetAttribute : IDateSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<Date> Value { get; set; }
        public IEnumerable<Date> ValueEnumerable { set => Value = value.ToList(); }

        public DateSetAttribute()
        {
            this.Type = "date-set";
        }
    }
}
