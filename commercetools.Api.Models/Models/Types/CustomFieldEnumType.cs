using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class CustomFieldEnumType : FieldType
    {
        public List<CustomFieldEnumValue> Values { get; set;}
    }
}
