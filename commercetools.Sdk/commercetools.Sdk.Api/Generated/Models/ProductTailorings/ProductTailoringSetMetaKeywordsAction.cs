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

    public partial class ProductTailoringSetMetaKeywordsAction : IProductTailoringSetMetaKeywordsAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaKeywords { get; set; }

        public bool? Staged { get; set; }
        public ProductTailoringSetMetaKeywordsAction()
        {
            this.Action = "setMetaKeywords";
        }
    }
}
