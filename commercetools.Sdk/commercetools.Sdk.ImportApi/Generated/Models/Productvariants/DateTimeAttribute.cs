using System;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
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
