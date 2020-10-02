using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeInputHint")]
    public partial class ProductTypeChangeInputHintAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public string NewValue { get; set;}
        
        [JsonIgnore]
        public TextInputHint NewValueAsEnum => this.NewValue.GetEnum<TextInputHint>();
        public ProductTypeChangeInputHintAction()
        { 
           this.Action = "changeInputHint";
        }
    }
}
