using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductChangeNameAction : IProductChangeNameAction
    {
        public string Action { get; set;}
        
        public ILocalizedString Name { get; set;}
        
        public bool? Staged { get; set;}
        public ProductChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}
