using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ProductSelectionProductRemovedMessagePayload : IProductSelectionProductRemovedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public ProductSelectionProductRemovedMessagePayload()
        {
            this.Type = "ProductSelectionProductRemoved";
        }
    }
}
