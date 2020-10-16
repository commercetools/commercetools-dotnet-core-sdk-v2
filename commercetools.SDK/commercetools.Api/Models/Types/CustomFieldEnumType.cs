using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Enum")]
    public partial class CustomFieldEnumType : FieldType
    {
        public List<CustomFieldEnumValue> Values { get; set;}
        public CustomFieldEnumType()
        { 
           this.Name = "Enum";
        }
    }
}
