using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("changeName")]
    public partial class ProductChangeNameAction : ProductUpdateAction
    {
        public LocalizedString Name { get; set;}
        
        public bool Staged { get; set;}
        public ProductChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
