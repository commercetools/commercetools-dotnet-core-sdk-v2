using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("LocalizedEnum")]
    public partial class CustomFieldLocalizedEnumType : FieldType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
        public CustomFieldLocalizedEnumType()
        { 
           this.Name = "LocalizedEnum";
        }
    }
}
