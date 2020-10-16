using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("addEnumValue")]
    public partial class TypeAddEnumValueAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public CustomFieldEnumValue Value { get; set;}
        public TypeAddEnumValueAction()
        { 
           this.Action = "addEnumValue";
        }
    }
}
