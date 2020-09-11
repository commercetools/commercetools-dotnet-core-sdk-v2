using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Types
{
    public class FieldDefinition 
    {
        public FieldType Type { get; set;}
        
        public string Name { get; set;}
        
        public LocalizedString Label { get; set;}
        
        public bool Required { get; set;}
        
        public TypeTextInputHint InputHint { get; set;}
    }
}
