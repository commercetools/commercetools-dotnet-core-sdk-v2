using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class StringField : IStringField
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public StringField()
        {
            this.Type = "String";
        }
    }
}
