using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class TimeSetAttribute : ITimeSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<TimeSpan> Value { get; set; }
        public TimeSetAttribute()
        {
            this.Type = "time-set";
        }
    }
}
