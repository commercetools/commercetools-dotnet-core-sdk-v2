using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeFieldDefinitionOrder")]
    public partial class TypeChangeFieldDefinitionOrderAction : TypeUpdateAction
    {
        public List<string> FieldNames { get; set;}
        public TypeChangeFieldDefinitionOrderAction()
        { 
           this.Action = "changeFieldDefinitionOrder";
        }
    }
}
