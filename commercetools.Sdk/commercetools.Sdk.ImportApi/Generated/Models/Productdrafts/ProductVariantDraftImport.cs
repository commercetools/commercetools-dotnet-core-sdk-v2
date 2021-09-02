using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Productdrafts;
using commercetools.ImportApi.Models.Productvariants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Productdrafts
{
    public partial class ProductVariantDraftImport : IProductVariantDraftImport
    {
        public string Sku { get; set; }

        public string Key { get; set; }

        public List<IPriceDraftImport> Prices { get; set; }

        public List<IAttribute> Attributes { get; set; }

        public List<IImage> Images { get; set; }

        public List<IAsset> Assets { get; set; }
    }
}
