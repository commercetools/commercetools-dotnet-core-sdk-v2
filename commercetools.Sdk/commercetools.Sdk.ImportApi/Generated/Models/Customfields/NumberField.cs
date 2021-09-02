using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class NumberField : INumberField
    {
        public string Type { get; set; }

        public double Value { get; set; }
        public NumberField()
        {
            this.Type = "Number";
        }
    }
}
