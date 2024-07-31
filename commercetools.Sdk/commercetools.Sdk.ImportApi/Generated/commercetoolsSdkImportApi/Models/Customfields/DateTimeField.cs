using System;

namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateTimeField : IDateTimeField
    {
        public string Type { get; set; }

        public DateTime Value { get; set; }
        public DateTimeField()
        {
            this.Type = "DateTime";
        }
    }
}
