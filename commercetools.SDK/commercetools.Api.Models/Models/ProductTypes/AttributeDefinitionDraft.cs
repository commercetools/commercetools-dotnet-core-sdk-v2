using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public class AttributeDefinitionDraft 
    {
        public AttributeType Type { get; set;}
        
        public string Name { get; set;}
        
        public LocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public string AttributeConstraint { get; set;}
        
        public AttributeConstraintEnum AttributeConstraintAsEnum => this.AttributeConstraint.GetEnum<AttributeConstraintEnum>();
        
        public LocalizedString InputTip { get; set;}
        
        public string InputHint { get; set;}
        
        public TextInputHint InputHintAsEnum => this.InputHint.GetEnum<TextInputHint>();
        
        public bool IsSearchable { get; set;}
    }
}
