using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.ProductTypes;
using Attribute = commercetools.Api.Generated.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.ProductTypes
{
    public interface IAttributeDefinition 
    {
        IAttributeType Type { get; set;}
        
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
        
        bool IsRequired { get; set;}
        
        string AttributeConstraint { get; set;}
        
        AttributeConstraintEnum AttributeConstraintAsEnum { get; }
        
        ILocalizedString InputTip { get; set;}
        
        string InputHint { get; set;}
        
        TextInputHint InputHintAsEnum { get; }
        
        bool IsSearchable { get; set;}
    }
}
