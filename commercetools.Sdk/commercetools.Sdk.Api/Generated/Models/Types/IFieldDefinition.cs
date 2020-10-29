using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Types
{
    [DeserializeAs(typeof(commercetools.Api.Models.Types.FieldDefinition))]
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
