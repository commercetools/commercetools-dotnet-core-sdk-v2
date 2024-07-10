using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class LocalizedEnumSetField : ILocalizedEnumSetField
    {
        public string Type { get; set; }

        public IList<string> Value { get; set; }
        public IEnumerable<string> ValueEnumerable { set => Value = value.ToList(); }

        public LocalizedEnumSetField()
        {
            this.Type = "LocalizedEnumSet";
        }
    }
}
