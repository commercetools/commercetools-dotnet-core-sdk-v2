using commercetools.Sdk.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Products
{

    public partial class ProductSetImageLabelAction : IProductSetImageLabelAction
    {
        public string Action { get; set; }

        public string Sku { get; set; }

        public long? VariantId { get; set; }

        public string ImageUrl { get; set; }

        public string Label { get; set; }

        public bool? Staged { get; set; }
        public ProductSetImageLabelAction()
        {
            this.Action = "setImageLabel";
        }
    }
}
