using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPriceModeAction : IProductSetPriceModeAction
    {
        public string Action { get; set; }

        public IProductPriceModeEnum PriceMode { get; set; }
        public ProductSetPriceModeAction()
        {
            this.Action = "setPriceMode";
        }
    }
}
