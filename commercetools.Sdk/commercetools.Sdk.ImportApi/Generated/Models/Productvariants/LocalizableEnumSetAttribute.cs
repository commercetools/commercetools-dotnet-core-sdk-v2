using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productvariants
{
    public partial class LocalizableEnumSetAttribute : ILocalizableEnumSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public List<string> Value { get; set; }
        public LocalizableEnumSetAttribute()
        {
            this.Type = "lenum-set";
        }
    }
}
