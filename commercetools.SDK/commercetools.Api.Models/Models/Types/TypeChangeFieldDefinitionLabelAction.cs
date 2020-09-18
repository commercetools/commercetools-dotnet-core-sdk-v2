using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeFieldDefinitionLabel")]
    public class TypeChangeFieldDefinitionLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}
