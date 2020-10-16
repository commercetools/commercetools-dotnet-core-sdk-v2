using commercetools.Api.Models.ProductTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DiscriminatorValue("changeDescription")]
    public partial class ProductTypeChangeDescriptionAction : ProductTypeUpdateAction
    {
        public string Description { get; set;}
        public ProductTypeChangeDescriptionAction()
        { 
           this.Action = "changeDescription";
        }
    }
}
