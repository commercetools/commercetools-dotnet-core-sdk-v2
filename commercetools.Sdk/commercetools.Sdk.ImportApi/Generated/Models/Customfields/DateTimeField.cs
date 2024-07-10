using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
