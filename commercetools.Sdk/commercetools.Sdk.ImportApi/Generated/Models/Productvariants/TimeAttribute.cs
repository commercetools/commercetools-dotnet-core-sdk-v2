using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class TimeAttribute : ITimeAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public TimeSpan Value { get; set; }
        public TimeAttribute()
        {
            this.Type = "time";
        }
    }
}
