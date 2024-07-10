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

    public partial class ProductTailoringSetAssetSourcesAction : IProductTailoringSetAssetSourcesAction
    {
        public string Action { get; set; }

        public long? VariantId { get; set; }

        public string Sku { get; set; }

        public bool? Staged { get; set; }

        public string AssetId { get; set; }

        public string AssetKey { get; set; }

        public IList<IAssetSource> Sources { get; set; }
        public IEnumerable<IAssetSource> SourcesEnumerable { set => Sources = value.ToList(); }

        public ProductTailoringSetAssetSourcesAction()
        {
            this.Action = "setAssetSources";
        }
    }
}
