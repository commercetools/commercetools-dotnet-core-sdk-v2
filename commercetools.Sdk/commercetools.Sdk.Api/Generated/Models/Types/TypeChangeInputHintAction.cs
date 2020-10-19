using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DiscriminatorValue("changeInputHint")]
    public partial class TypeChangeInputHintAction : TypeUpdateAction
    {
        public string FieldName { get; set;}
        
        public string InputHint { get; set;}
        
        [JsonIgnore]
        public TypeTextInputHint InputHintAsEnum => this.InputHint.GetEnum<TypeTextInputHint>();
        public TypeChangeInputHintAction()
        { 
           this.Action = "changeInputHint";
        }
    }
}
