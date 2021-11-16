using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class ProductTypeChangeAttributeOrderAction : IProductTypeChangeAttributeOrderAction
    {
        public string Action { get; set;}
        
        public List<IAttributeDefinition> Attributes { get; set;}
        public ProductTypeChangeAttributeOrderAction()
        { 
           this.Action = "changeAttributeOrder";
        }
    }
}
