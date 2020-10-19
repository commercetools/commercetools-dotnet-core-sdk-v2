using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeLocalizedEnumValueLabel")]
    public partial class TypeChangeLocalizedEnumValueLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldLocalizedEnumValue Value { get; set;}
        public TypeChangeLocalizedEnumValueLabelAction()
        { 
           this.Action = "changeLocalizedEnumValueLabel";
        }
    }
}
