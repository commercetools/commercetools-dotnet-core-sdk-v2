using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringMoveImageToPositionAction : IProductTailoringMoveImageToPositionAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public string ImageUrl { get; set; }

        public long Position { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringMoveImageToPositionAction()
        {
            this.Action = "moveImageToPosition";
        }
    }
}
