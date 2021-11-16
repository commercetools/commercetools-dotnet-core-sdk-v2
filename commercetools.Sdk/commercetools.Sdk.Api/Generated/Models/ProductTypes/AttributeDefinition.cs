using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeDefinition : IAttributeDefinition
    {
        public IAttributeType Type { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public IAttributeConstraintEnum AttributeConstraint { get; set;}
        
        public ILocalizedString InputTip { get; set;}
        
        public ITextInputHint InputHint { get; set;}
        
        public bool IsSearchable { get; set;}
    }
}
