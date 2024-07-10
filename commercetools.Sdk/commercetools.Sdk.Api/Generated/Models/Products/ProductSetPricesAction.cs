using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetPricesAction : IProductSetPricesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public IList<IPriceDraft> Prices { get; set; }
        public IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        public bool? Staged { get; set; }
        public ProductSetPricesAction()
        {
            this.Action = "setPrices";
        }
    }
}
