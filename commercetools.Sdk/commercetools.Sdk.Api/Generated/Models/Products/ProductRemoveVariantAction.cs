using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public  partial class ProductRemoveVariantAction : IProductRemoveVariantAction
    {
        public string Action { get; set;}
        
        public long Id { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemoveVariantAction()
        { 
           this.Action = "removeVariant";
        }
    }
}
