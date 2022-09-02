using System.Collections.Generic;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class DateSetField : IDateSetField
    {
        public string Type { get; set; }

        public List<Date> Value { get; set; }
        public DateSetField()
        {
            this.Type = "DateSet";
        }
    }
}
