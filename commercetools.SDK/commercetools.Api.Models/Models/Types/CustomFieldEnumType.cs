using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("Enum")]
    public class CustomFieldEnumType : FieldType
    {
        public List<CustomFieldEnumValue> Values { get; set;}
    }
}
