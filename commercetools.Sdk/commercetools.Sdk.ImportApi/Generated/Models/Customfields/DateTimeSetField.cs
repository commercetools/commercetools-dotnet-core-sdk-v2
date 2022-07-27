using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateTimeSetField : IDateTimeSetField
    {
        public string Type { get; set; }

        public List<DateTime> Value { get; set; }
        public DateTimeSetField()
        {
            this.Type = "DateTimeSet";
        }
    }
}
