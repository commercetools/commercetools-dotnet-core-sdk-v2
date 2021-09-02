using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class LocalizedEnumField : ILocalizedEnumField
    {
        public string Type { get; set; }

        public string Value { get; set; }
        public LocalizedEnumField()
        {
            this.Type = "LocalizedEnum";
        }
    }
}
