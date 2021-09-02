using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class BooleanSetField : IBooleanSetField
    {
        public string Type { get; set; }

        public List<bool> Value { get; set; }
        public BooleanSetField()
        {
            this.Type = "BooleanSet";
        }
    }
}
