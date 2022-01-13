using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class DateSetField : IDateSetField
    {
        public string Type { get; set; }

        public List<DateTime> Value { get; set; }
        public DateSetField()
        {
            this.Type = "DateSet";
        }
    }
}
