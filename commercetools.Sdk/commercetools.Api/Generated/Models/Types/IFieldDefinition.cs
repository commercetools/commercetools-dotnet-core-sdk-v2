using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Types
{
    public interface IFieldDefinition 
    {
        IFieldType Type { get; set;}
        
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
        
        bool Required { get; set;}
        
        string InputHint { get; set;}
        
        TypeTextInputHint InputHintAsEnum { get; }
    }
}
