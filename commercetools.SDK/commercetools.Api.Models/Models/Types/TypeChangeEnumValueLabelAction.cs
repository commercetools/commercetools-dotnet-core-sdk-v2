using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeEnumValueLabel")]
    public class TypeChangeEnumValueLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldEnumValue Value { get; set;}
    }
}
