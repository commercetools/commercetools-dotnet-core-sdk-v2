using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class NumberSetAttribute : INumberSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<decimal> Value { get; set; }
        public IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }

        public NumberSetAttribute()
        {
            this.Type = "number-set";
        }
    }
}
