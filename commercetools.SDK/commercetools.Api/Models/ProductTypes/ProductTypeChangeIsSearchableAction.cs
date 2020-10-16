using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeIsSearchable")]
    public partial class ProductTypeChangeIsSearchableAction : ProductTypeUpdateAction
    {
        public string AttributeName { get; set;}
        
        public bool IsSearchable { get; set;}
        public ProductTypeChangeIsSearchableAction()
        { 
           this.Action = "changeIsSearchable";
        }
    }
}
