using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPriceKeyAction : IProductSetPriceKeyAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public bool? Staged { get; set; }

        public string Key { get; set; }
        public ProductSetPriceKeyAction()
        {
            this.Action = "setPriceKey";
        }
    }
}
