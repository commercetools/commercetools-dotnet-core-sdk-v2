using commercetools.Api.Models.Products;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("setProductPriceCustomType")]
    public partial class ProductSetProductPriceCustomTypeAction : ProductUpdateAction
    {
        public string PriceId { get; set;}
        
        public bool Staged { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public ProductSetProductPriceCustomTypeAction()
        { 
           this.Action = "setProductPriceCustomType";
        }
    }
}
