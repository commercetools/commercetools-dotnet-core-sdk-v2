using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTailorings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductTailoringSetSlugAction : IProductTailoringSetSlugAction
    {
        public string Action { get; set; }

        public ILocalizedString Slug { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetSlugAction()
        {
            this.Action = "setSlug";
        }
    }
}
