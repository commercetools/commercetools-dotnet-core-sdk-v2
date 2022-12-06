using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Productvariants;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productdrafts.ProductVariantDraftImport))]
    public partial interface IProductVariantDraftImport
    {
        string Sku { get; set; }

        string Key { get; set; }

        IList<IPriceDraftImport> Prices { get; set; }
        IEnumerable<IPriceDraftImport> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        IList<IAsset> Assets { get; set; }
        IEnumerable<IAsset> AssetsEnumerable { set => Assets = value.ToList(); }


    }
}
