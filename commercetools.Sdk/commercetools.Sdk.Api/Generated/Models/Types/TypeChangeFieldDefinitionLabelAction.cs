using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeFieldDefinitionLabel")]
    public partial class TypeChangeFieldDefinitionLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public LocalizedString Label { get; set;}
        public TypeChangeFieldDefinitionLabelAction()
        { 
           this.Action = "changeFieldDefinitionLabel";
        }
    }
}
