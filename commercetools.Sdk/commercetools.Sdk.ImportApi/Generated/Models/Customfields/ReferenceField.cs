using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Customfields
{
    public partial class ReferenceField : IReferenceField
    {
        public string Type { get; set; }

        public IKeyReference Value { get; set; }
        public ReferenceField()
        {
            this.Type = "Reference";
        }
    }
}
