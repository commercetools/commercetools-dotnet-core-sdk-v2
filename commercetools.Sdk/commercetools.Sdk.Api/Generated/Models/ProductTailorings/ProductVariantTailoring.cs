using commercetools.Sdk.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.ProductTailorings
{

    public partial class ProductVariantTailoring : IProductVariantTailoring
    {
        public long Id { get; set; }

        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        public IList<IAsset> Assets { get; set; }
        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

    }
}
