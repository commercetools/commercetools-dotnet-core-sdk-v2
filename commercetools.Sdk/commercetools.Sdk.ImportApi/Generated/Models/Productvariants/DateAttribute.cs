using System;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class DateAttribute : IDateAttribute
    {
        public string Name { get; set;}
        
        public string Type { get; set;}
        
        public DateTime Value { get; set;}
        public DateAttribute()
        { 
           this.Type = "date";
        }
    }
}
