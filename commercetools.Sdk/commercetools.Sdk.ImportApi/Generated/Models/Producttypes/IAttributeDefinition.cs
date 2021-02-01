using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeDefinition))]
    public partial interface IAttributeDefinition 
    {
        IAttributeType Type { get; set;}
        
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
        
        bool IsRequired { get; set;}
        
        IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        ILocalizedString InputTip { get; set;}
        
        ITextInputHint InputHint { get; set;}
        
        bool? IsSearchable { get; set;}
    }
}
