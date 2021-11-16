using System;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class DateField : IDateField
    {
        public string Type { get; set;}
        
        public DateTime Value { get; set;}
        public DateField()
        { 
           this.Type = "Date";
        }
    }
}
