using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetDiscountedPriceAction : IProductSetDiscountedPriceAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public bool? Staged { get; set; }

        public IDiscountedPrice Discounted { get; set; }
        public ProductSetDiscountedPriceAction()
        {
            this.Action = "setDiscountedPrice";
        }
    }
}
