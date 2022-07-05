using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Productdrafts
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
