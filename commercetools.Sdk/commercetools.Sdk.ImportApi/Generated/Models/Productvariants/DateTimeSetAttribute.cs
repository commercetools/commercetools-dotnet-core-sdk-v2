using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class DateTimeSetAttribute : IDateTimeSetAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public List<DateTime> Value { get; set;}
        public DateTimeSetAttribute()
        { 
           this.Type = "datetime-set";
        }
    }
}
