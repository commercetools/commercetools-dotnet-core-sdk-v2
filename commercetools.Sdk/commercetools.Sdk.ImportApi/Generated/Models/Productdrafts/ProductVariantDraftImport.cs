using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productdrafts;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Productdrafts
{

    public partial class ProductVariantDraftImport : IProductVariantDraftImport
    {
        public string Sku { get; set; }

        public string Key { get; set; }

        public IList<IPriceDraftImport> Prices { get; set; }
        public IEnumerable<IPriceDraftImport> PricesEnumerable { set => Prices = value.ToList(); }


        public IList<IAttribute> Attributes { get; set; }
        public IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        public IList<IImage> Images { get; set; }
        public IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        public IList<IAsset> Assets { get; set; }
        public IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }

    }
}
