using System.Collections.Generic;
using System.Linq;
using System;

namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class TimeSetAttribute : ITimeSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<TimeSpan> Value { get; set; }

        public IEnumerable<TimeSpan> ValueEnumerable { set => Value = value.ToList(); }
        public TimeSetAttribute()
        {
            this.Type = "time-set";
        }
    }
}
