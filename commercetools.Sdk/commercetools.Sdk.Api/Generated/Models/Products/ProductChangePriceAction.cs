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

    public partial class ProductChangePriceAction : IProductChangePriceAction
    {
        public string Action { get; set; }

        public string PriceId { get; set; }

        public IPriceDraft Price { get; set; }

        public bool? Staged { get; set; }
        public ProductChangePriceAction()
        {
            this.Action = "changePrice";
        }
    }
}
