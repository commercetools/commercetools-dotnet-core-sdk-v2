using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateTimeSetField : IDateTimeSetField
    {
        public string Type { get; set; }

        public IList<DateTime> Value { get; set; }
        public IEnumerable<DateTime> ValueEnumerable { set => Value = value.ToList(); }

        public DateTimeSetField()
        {
            this.Type = "DateTimeSet";
        }
    }
}
