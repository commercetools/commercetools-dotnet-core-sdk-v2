using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Types
{
    public partial class FieldDefinition 
    {
        public FieldType Type { get; set;}
        
        public string Name { get; set;}
        
        public LocalizedString Label { get; set;}
        
        public bool Required { get; set;}
        
        public string InputHint { get; set;}
        
        [JsonIgnore]
        public TypeTextInputHint InputHintAsEnum => this.InputHint.GetEnum<TypeTextInputHint>();
    }
}
