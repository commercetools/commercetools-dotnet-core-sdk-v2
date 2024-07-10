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

    public partial class ProductSetMetaTitleAction : IProductSetMetaTitleAction
    {
        public string Action { get; set; }

        public ILocalizedString MetaTitle { get; set; }

        public bool? Staged { get; set; }
        public ProductSetMetaTitleAction()
        {
            this.Action = "setMetaTitle";
        }
    }
}
