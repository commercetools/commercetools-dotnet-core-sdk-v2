using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ProductTypes
{
    public class AttributeDefinitionDraft 
    {
        public AttributeType Type { get; set;}
        
        public string Name { get; set;}
        
        public LocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public AttributeConstraintEnum AttributeConstraint { get; set;}
        
        public LocalizedString InputTip { get; set;}
        
        public TextInputHint InputHint { get; set;}
        
        public bool IsSearchable { get; set;}
    }
}
