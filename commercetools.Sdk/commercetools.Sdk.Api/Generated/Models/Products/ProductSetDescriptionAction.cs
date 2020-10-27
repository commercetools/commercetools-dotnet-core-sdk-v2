using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductSetDescriptionAction : IProductSetDescriptionAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Description { get; set;}
        
        public bool? Staged { get; set;}
        public ProductSetDescriptionAction()
        { 
           this.Action = "setDescription";
        }
    }
}
