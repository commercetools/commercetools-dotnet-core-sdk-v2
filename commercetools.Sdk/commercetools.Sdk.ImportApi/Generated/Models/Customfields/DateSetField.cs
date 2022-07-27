using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Customfields
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
