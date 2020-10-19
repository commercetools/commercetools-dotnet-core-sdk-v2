using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("addLocalizedEnumValue")]
    public partial class TypeAddLocalizedEnumValueAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldLocalizedEnumValue Value { get; set;}
        public TypeAddLocalizedEnumValueAction()
        { 
           this.Action = "addLocalizedEnumValue";
        }
    }
}
