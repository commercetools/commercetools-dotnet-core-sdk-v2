using commercetools.Sdk.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{

    public partial class ProductDiscountSetValidUntilAction : IProductDiscountSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public ProductDiscountSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
