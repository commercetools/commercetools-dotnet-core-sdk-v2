using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("addLocalizedEnumValue")]
    public class TypeAddLocalizedEnumValueAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldLocalizedEnumValue Value { get; set;}
    }
}
