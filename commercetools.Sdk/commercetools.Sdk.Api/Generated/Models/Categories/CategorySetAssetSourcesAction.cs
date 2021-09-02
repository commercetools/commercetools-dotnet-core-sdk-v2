using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    public partial class CategorySetAssetSourcesAction : ICategorySetAssetSourcesAction
    {
        public string Action { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public List<IAssetSource> Sources { get; set; }
        public CategorySetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}
