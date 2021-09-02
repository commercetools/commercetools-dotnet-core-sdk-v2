using commercetools.Api.Models.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetAssetCustomFieldAction : ICategorySetAssetCustomFieldAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public CategorySetAssetCustomFieldAction()
        {
            this.Action = "setAssetCustomField";
        }
    }
}
