using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class TimeAttribute : ITimeAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public ITimeSpan Value { get; set;}
        public TimeAttribute()
        { 
           this.Type = "time";
        }
    }
}
