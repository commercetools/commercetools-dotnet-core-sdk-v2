using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class CustomFieldLocalizedEnumType : FieldType
    {
        public List<CustomFieldLocalizedEnumValue> Values { get; set;}
    }
}
