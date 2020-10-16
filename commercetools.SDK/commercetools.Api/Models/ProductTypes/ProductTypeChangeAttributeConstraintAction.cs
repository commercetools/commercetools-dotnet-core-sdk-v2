using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeConstraint")]
    public partial class ProductTypeChangeAttributeConstraintAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string NewValue { get; set;}
        
        [JsonIgnore]
        public AttributeConstraintEnumDraft NewValueAsEnum => this.NewValue.GetEnum<AttributeConstraintEnumDraft>();
        public ProductTypeChangeAttributeConstraintAction()
        { 
           this.Action = "changeAttributeConstraint";
        }
    }
}
