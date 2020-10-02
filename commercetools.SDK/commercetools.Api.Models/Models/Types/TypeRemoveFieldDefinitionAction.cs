using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("removeFieldDefinition")]
    public partial class TypeRemoveFieldDefinitionAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        public TypeRemoveFieldDefinitionAction()
        { 
           this.Action = "removeFieldDefinition";
        }
    }
}
