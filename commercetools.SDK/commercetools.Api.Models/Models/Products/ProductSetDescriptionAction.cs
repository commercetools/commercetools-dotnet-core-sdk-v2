using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setDescription")]
    public partial class ProductSetDescriptionAction : ProductUpdateAction
    {
        public LocalizedString Description { get; set;}
        
        public bool Staged { get; set;}
        public ProductSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
