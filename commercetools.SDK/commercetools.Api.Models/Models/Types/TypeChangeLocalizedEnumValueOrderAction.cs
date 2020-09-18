using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeLocalizedEnumValueOrder")]
    public class TypeChangeLocalizedEnumValueOrderAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public List<string> Keys { get; set;}
    }
}
