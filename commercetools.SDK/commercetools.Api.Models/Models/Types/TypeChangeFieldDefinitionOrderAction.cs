using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeFieldDefinitionOrder")]
    public class TypeChangeFieldDefinitionOrderAction : TypeUpdateAction
    {
        public List<string> FieldNames { get; set;}
    }
}
