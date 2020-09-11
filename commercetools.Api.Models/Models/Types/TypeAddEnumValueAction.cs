using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class TypeAddEnumValueAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldEnumValue Value { get; set;}
    }
}
