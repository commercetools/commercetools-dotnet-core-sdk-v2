using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class DateTimeSetAttribute : IDateTimeSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<DateTime> Value { get; set; }
        public IEnumerable<DateTime> ValueEnumerable { set => Value = value.ToList(); }

        public DateTimeSetAttribute()
        {
            this.Type = "datetime-set";
        }
    }
}
