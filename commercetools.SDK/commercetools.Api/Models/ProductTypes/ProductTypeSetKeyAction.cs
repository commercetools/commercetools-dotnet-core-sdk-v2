using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("setKey")]
    public partial class ProductTypeSetKeyAction : ProductTypeUpdateAction
    {
        public string Key { get; set;}
        public ProductTypeSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
