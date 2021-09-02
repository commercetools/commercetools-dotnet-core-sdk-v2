using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
