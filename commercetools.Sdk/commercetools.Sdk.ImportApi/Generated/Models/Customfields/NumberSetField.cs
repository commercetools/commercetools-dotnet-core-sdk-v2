using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Customfields
{

    public partial class NumberSetField : INumberSetField
    {
        public string Type { get; set; }

        public IList<decimal> Value { get; set; }
        public IEnumerable<decimal> ValueEnumerable { set => Value = value.ToList(); }

        public NumberSetField()
        {
            this.Type = "NumberSet";
        }
    }
}
