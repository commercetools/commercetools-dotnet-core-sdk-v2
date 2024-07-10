using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productvariants
{

    public partial class ReferenceSetAttribute : IReferenceSetAttribute
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public IList<IKeyReference> Value { get; set; }
        public IEnumerable<IKeyReference> ValueEnumerable { set => Value = value.ToList(); }

        public ReferenceSetAttribute()
        {
            this.Type = "reference-set";
        }
    }
}
