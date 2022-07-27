using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class DateSetAttribute : IDateSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<DateTime> Value { get; set; }
        public DateSetAttribute()
        {
            this.Type = "date-set";
        }
    }
}
