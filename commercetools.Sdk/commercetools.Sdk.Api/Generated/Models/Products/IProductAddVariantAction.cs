using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductAddVariantAction))]
    public partial interface IProductAddVariantAction : IProductUpdateAction
    {
        string Sku { get; set; }

        string Key { get; set; }

        IList<IPriceDraft> Prices { get; set; }
        IEnumerable<IPriceDraft> PricesEnumerable { set => Prices = value.ToList(); }


        IList<IImage> Images { get; set; }
        IEnumerable<IImage> ImagesEnumerable { set => Images = value.ToList(); }


        IList<IAttribute> Attributes { get; set; }
        IEnumerable<IAttribute> AttributesEnumerable { set => Attributes = value.ToList(); }


        bool? Staged { get; set; }

        IList<IAssetDraft> Assets { get; set; }
        IEnumerable<IAssetDraft> AssetsEnumerable { set => Assets = value.ToList(); }


    }
}
