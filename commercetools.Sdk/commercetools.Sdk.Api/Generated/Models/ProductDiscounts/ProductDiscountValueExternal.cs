using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountValueExternal : IProductDiscountValueExternal
    {
        public string Type { get; set; }
        public ProductDiscountValueExternal()
        {
            this.Type = "external";
        }
    }
}
