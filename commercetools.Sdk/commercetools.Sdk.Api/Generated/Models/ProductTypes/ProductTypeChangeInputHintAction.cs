using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public  partial class ProductTypeChangeInputHintAction : IProductTypeChangeInputHintAction
    {
        public string Action { get; set;}
        
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
