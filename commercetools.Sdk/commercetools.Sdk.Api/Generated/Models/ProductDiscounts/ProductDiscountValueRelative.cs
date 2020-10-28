using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueRelative : IProductDiscountValueRelative
    {
        public string Type { get; set;}
        
        public long Permyriad { get; set;}
        public ProductDiscountValueRelative()
        { 
           this.Type = "relative";
        }
    }
}
