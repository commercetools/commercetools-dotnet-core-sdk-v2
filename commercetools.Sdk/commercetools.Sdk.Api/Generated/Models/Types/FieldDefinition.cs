using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    public  partial class FieldDefinition : IFieldDefinition
    {
        public IFieldType Type { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString Label { get; set;}
        
        public bool Required { get; set;}
        
        public string InputHint { get; set;}
        
        [JsonIgnore]
        public TypeTextInputHint InputHintAsEnum => this.InputHint.GetEnum<TypeTextInputHint>();
    }
}
