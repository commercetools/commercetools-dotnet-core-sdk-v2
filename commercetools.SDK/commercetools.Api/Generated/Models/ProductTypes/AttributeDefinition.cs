using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeDefinition 
    {
        public AttributeType Type { get; set;}
        
        public string Name { get; set;}
        
        public LocalizedString Label { get; set;}
        
        public bool IsRequired { get; set;}
        
        public string AttributeConstraint { get; set;}
        
        [JsonIgnore]
        public AttributeConstraintEnum AttributeConstraintAsEnum => this.AttributeConstraint.GetEnum<AttributeConstraintEnum>();
        
        public LocalizedString InputTip { get; set;}
        
        public string InputHint { get; set;}
        
        [JsonIgnore]
        public TextInputHint InputHintAsEnum => this.InputHint.GetEnum<TextInputHint>();
        
        public bool IsSearchable { get; set;}
    }
}
