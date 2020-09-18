using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("LocalizedEnum")]
    public class CustomFieldLocalizedEnumType : FieldType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
    }
}
