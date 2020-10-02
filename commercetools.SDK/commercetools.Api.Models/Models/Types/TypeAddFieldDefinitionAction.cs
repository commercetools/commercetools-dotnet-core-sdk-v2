using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("addFieldDefinition")]
    public partial class TypeAddFieldDefinitionAction : TypeUpdateAction
    {
        public FieldDefinition FieldDefinition { get; set;}
        public TypeAddFieldDefinitionAction()
        { 
           this.Action = "addFieldDefinition";
        }
    }
}
