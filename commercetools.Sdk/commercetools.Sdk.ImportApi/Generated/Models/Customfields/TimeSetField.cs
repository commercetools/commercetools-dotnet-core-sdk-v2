using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class TimeSetField : ITimeSetField
    {
        public string Type { get; set; }

        public List<TimeSpan> Value { get; set; }
        public TimeSetField()
        {
            this.Type = "TimeSet";
        }
    }
}
