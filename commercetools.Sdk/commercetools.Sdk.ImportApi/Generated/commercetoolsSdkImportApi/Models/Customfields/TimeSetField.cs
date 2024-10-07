using System.Collections.Generic;
using System.Linq;
using System;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class TimeSetField : ITimeSetField
    {
        public string Type { get; set; }

        public IList<TimeSpan> Value { get; set; }

        public IEnumerable<TimeSpan> ValueEnumerable { set => Value = value.ToList(); }
        public TimeSetField()
        {
            this.Type = "TimeSet";
        }
    }
}
