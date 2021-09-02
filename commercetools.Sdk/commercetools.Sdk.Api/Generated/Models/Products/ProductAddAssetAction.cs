using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    public partial class ProductAddAssetAction : IProductAddAssetAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public IAssetDraft Asset { get; set; }

        public int? Position { get; set; }
        public ProductAddAssetAction()
        {
            this.Action = "addAsset";
        }
    }
}
