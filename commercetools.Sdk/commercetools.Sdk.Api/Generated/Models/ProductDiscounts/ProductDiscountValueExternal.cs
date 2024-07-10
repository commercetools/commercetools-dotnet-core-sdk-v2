using commercetools.Sdk.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
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
