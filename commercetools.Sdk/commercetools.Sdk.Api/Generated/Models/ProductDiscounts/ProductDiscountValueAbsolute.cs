using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueAbsolute : IProductDiscountValueAbsolute
    {
        public string Type { get; set;}
        
        public List<ITypedMoney> Money { get; set;}
        public ProductDiscountValueAbsolute()
        { 
           this.Type = "absolute";
        }
    }
}
