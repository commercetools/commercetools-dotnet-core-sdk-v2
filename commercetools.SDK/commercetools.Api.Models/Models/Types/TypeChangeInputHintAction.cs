using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeInputHint")]
    public class TypeChangeInputHintAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public string InputHint { get; set;}
        
        public TypeTextInputHint InputHintAsEnum => this.InputHint.GetEnum<TypeTextInputHint>();
    }
}
