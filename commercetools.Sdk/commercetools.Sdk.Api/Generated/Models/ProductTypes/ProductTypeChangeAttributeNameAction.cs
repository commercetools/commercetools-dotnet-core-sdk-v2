using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeNameAction : IProductTypeChangeAttributeNameAction
    {
        public string Action { get; set;}
        
        public string AttributeName { get; set;}
        
        public string NewAttributeName { get; set;}
        public ProductTypeChangeAttributeNameAction()
        { 
           this.Action = "changeAttributeName";
        }
    }
}
