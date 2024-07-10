using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringRemoveVariantAction : IProductTailoringRemoveVariantAction
    {
        public string Action { get; set; }

        public long? Id { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringRemoveVariantAction()
        {
            this.Action = "removeVariant";
        }
    }
}
