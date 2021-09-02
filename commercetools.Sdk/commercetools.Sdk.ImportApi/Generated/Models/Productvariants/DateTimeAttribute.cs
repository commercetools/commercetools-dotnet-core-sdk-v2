using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class DateTimeAttribute : IDateTimeAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Value { get; set; }
        public DateTimeAttribute()
        {
            this.Type = "datetime";
        }
    }
}
