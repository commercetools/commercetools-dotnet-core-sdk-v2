using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductSetPricesAction : IProductSetPricesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public List<IPriceDraft> Prices { get; set; }

        public bool? Staged { get; set; }
        public ProductSetPricesAction()
        {
            this.Action = "setPrices";
        }
    }
}
