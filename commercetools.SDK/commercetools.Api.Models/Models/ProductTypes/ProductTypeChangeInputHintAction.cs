using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeInputHint")]
    public class ProductTypeChangeInputHintAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string NewValue { get; set;}
        
        public TextInputHint NewValueAsEnum => this.NewValue.GetEnum<TextInputHint>();
    }
}
