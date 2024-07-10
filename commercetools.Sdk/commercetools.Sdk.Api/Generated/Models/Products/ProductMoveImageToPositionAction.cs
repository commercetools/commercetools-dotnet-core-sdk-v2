using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductMoveImageToPositionAction : IProductMoveImageToPositionAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public long Position { get; set; }

        public bool? Staged { get; set; }
        public ProductMoveImageToPositionAction()
        {
            this.Action = "moveImageToPosition";
        }
    }
}
