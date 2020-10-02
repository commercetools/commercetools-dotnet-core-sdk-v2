using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Number")]
    public partial class CustomFieldNumberType : FieldType
    {
        public CustomFieldNumberType()
        { 
           this.Name = "Number";
        }
    }
}
