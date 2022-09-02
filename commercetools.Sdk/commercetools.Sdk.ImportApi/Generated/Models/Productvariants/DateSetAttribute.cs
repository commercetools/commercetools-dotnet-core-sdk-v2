using System.Collections.Generic;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class DateSetAttribute : IDateSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<Date> Value { get; set; }
        public DateSetAttribute()
        {
            this.Type = "date-set";
        }
    }
}
