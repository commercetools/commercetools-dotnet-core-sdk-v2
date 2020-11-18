using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeDefinition))]
    public partial interface IAttributeDefinition 
    {
        IAttributeType Type { get; set;}
        
        string Name { get; set;}
        
        ILocalizedString Label { get; set;}
        
        bool IsRequired { get; set;}
        
        IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        ILocalizedString InputTip { get; set;}
        
        ITextInputHint InputHint { get; set;}
        
        bool IsSearchable { get; set;}
    }
}
