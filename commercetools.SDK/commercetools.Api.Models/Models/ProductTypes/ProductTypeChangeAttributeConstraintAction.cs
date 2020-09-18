using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeAttributeConstraint")]
    public class ProductTypeChangeAttributeConstraintAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string NewValue { get; set;}
        
        public AttributeConstraintEnumDraft NewValueAsEnum => this.NewValue.GetEnum<AttributeConstraintEnumDraft>();
    }
}
