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
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.AttributeDefinitionDraft))]
    public partial interface IAttributeDefinitionDraft 
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
        
        bool? IsSearchable { get; set;}
    }
}
