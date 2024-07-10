using commercetools.Sdk.Api.Models.Categories;
using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Categories
{

    public partial class CategorySetAssetDescriptionAction : ICategorySetAssetDescriptionAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public ILocalizedString Description { get; set; }
        public CategorySetAssetDescriptionAction()
        {
            this.Action = "setAssetDescription";
        }
    }
}
