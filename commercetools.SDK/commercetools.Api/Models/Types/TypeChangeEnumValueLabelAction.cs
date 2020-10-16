using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeEnumValueLabel")]
    public partial class TypeChangeEnumValueLabelAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldEnumValue Value { get; set;}
        public TypeChangeEnumValueLabelAction()
        { 
           this.Action = "changeEnumValueLabel";
        }
    }
}
