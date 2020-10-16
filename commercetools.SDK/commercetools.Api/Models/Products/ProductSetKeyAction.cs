using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setKey")]
    public partial class ProductSetKeyAction : ProductUpdateAction
    {
        public string Key { get; set;}
        public ProductSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
