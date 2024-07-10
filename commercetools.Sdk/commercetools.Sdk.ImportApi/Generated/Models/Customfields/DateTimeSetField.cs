using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
