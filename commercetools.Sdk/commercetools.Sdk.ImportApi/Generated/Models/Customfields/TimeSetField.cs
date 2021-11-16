using System;
using System.Collections.Generic;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class TimeSetField : ITimeSetField
    {
        public string Type { get; set;}
        
        public List<TimeSpan> Value { get; set;}
        public TimeSetField()
        { 
           this.Type = "TimeSet";
        }
    }
}
